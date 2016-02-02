using UnityEngine;
using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Collections;
using System.Collections.Generic;
using LuaFramework;
using System.Threading;

public enum DisType {
    Exception,
    Disconnect,
}

public class SocketClient {
    private TcpClient client = null;
    private NetworkStream outStream = null;
    private MemoryStream memStream;
    private BinaryReader reader;
    private Thread thread = null;

    private const int MAX_READ = 8192;
    private byte[] byteBuffer = new byte[MAX_READ];
    public static bool loggedIn = false;

    public enum netState {
        None = 0,
        ToConnect = 1,
        Connected = 2,
        ToDisconnect = 3,
        DisConnected = 4,
    };

    public netState sockteClientState = netState.None;

    // Use this for initialization
    public SocketClient()
    {
        
    }

    public void init()
    {
        OnRegister();
        thread = new Thread(start);
        thread.Start();
    }

    private void start()
    {
        while (true)
        {
            if (sockteClientState == netState.None)
            {
                Thread.Sleep(10);
            }
            else if (sockteClientState == netState.ToConnect)
            {
                SendConnect();
                Thread.Sleep(1000);//1秒连接一下
            }
            else if (sockteClientState == netState.Connected)
            {
                //send message
                lock(NetworkManager.toSendBuffers)
                {
                    while (NetworkManager.toSendBuffers.Count > 0)
                    {
                        ByteBuffer btbuffer = NetworkManager.toSendBuffers.Dequeue();
                        if (btbuffer != null)
                        {
                            SendMessage(btbuffer);
                        }
                    }
                }

                //recv messsage
                readMessage();
            }
            else if (sockteClientState == netState.ToDisconnect)
            {
                OnRemove();
                sockteClientState = netState.DisConnected;
                return;
            }
            Console.WriteLine("socket running!!");
        }
    }

    /// <summary>
    /// 注册代理
    /// </summary>
    public void OnRegister() {
        memStream = new MemoryStream();
        reader = new BinaryReader(memStream);
    }

    /// <summary>
    /// 移除代理
    /// </summary>
    public void OnRemove() {
        this.Close();
        reader.Close();
        memStream.Close();
    }

    /// <summary>
    /// 连接服务器
    /// </summary>
    void ConnectServer(string host, int port) {
        client = null;
        client = new TcpClient();
        client.SendTimeout = 1000;
        client.ReceiveTimeout = 1000;
        client.NoDelay = true;
        try {
            client.BeginConnect(host, port,new AsyncCallback(OnConnect),null);
        } catch (Exception e) {
            Close();
            //Debug.LogError(e.Message);
            lock (NetworkManager.sEvents)
            {
                NetworkManager.AddEvent(Protocal.ConnectFailer, new ByteBuffer());
            }
        }
    }

    /// <summary>
    /// Connect server callback
    /// </summary>
    void OnConnect(IAsyncResult asr)
    {
        if (client.Connected)// socket has connected to server.
        {
            lock (NetworkManager.sEvents)
            {
                NetworkManager.AddEvent(Protocal.Connect, new ByteBuffer());
            }
            sockteClientState = netState.Connected;
        }
        else
        {
            //Close();
            lock (NetworkManager.sEvents)
            {
                NetworkManager.AddEvent(Protocal.ConnectFailer, new ByteBuffer());
            }
        }
    }

    /// <summary>
    /// 写数据
    /// </summary>
    void WriteMessage(byte[] message) {
        MemoryStream ms = null;
        using (ms = new MemoryStream()) {
            ms.Position = 0;
            BinaryWriter writer = new BinaryWriter(ms);
            ushort msglen = (ushort)message.Length;
            writer.Write(msglen);
            writer.Write(message);
            writer.Flush();
            if (client != null && client.Connected) {
                //NetworkStream stream = client.GetStream(); 
                byte[] payload = ms.ToArray();
                outStream.Write(payload, 0, payload.Length);
            } else {
                Debug.LogError("client.connected----->>false");
            }
        }
    }

    /// <summary>
    /// 读取消息
    /// </summary>
    void readMessage() {
        int bytesRead = 0;
        SocketError error;
        try {
            lock (client.GetStream()) {         //读取字节流到缓冲区
                bytesRead = client.GetStream().ReadByte();
            }
            if (bytesRead < 1) {                //包尺寸有问题，断线处理
                OnDisconnected(DisType.Disconnect, "bytesRead < 1");
                return;
            }
            if (bytesRead > MAX_READ)//buff 不够的时候扩容
            {

            }
            client.Client.Receive(byteBuffer,0, bytesRead,SocketFlags.Peek,out error);//全部读出来
            OnReceive(byteBuffer, bytesRead);   //分析数据包内容，抛给逻辑层
            Array.Clear(byteBuffer, 0, byteBuffer.Length);   //清空数组
        } catch (Exception ex) {
            //PrintBytes();
            OnDisconnected(DisType.Exception, ex.Message);
        }
    }

    /// <summary>
    /// 丢失链接
    /// </summary>
    void OnDisconnected(DisType dis, string msg) {
        sockteClientState = netState.DisConnected;
        Close();   //关掉客户端链接
        int protocal = dis == DisType.Exception ?
        Protocal.Exception : Protocal.Disconnect;

        ByteBuffer buffer = new ByteBuffer();
        buffer.WriteShort((ushort)protocal);
        lock (NetworkManager.sEvents)
        {
            NetworkManager.AddEvent(protocal, buffer);
        }
        //Debug.LogError("Connection was closed by the server:>" + msg + " Distype:>" + dis);
    }

    /// <summary>
    /// 打印字节
    /// </summary>
    /// <param name="bytes"></param>
    void PrintBytes() {
        string returnStr = string.Empty;
        for (int i = 0; i < byteBuffer.Length; i++) {
            returnStr += byteBuffer[i].ToString("X2");
        }
        //Debug.LogError(returnStr);
    }

    /// <summary>
    /// 向链接写入数据流
    /// </summary>
    void OnWrite(IAsyncResult r) {
        try {
            outStream.EndWrite(r);
        } catch (Exception ex) {
            Debug.LogError("OnWrite--->>>" + ex.Message);
        }
    }

    /// <summary>
    /// 接收到消息
    /// </summary>
    void OnReceive(byte[] bytes, int length) {
        memStream.Seek(0, SeekOrigin.End);
        memStream.Write(bytes, 0, length);
        //Reset to beginning
        memStream.Seek(0, SeekOrigin.Begin);
        while (RemainingBytes() > 2) {
            ushort messageLen = reader.ReadUInt16();
            if (RemainingBytes() >= messageLen) {
                MemoryStream ms = new MemoryStream();
                BinaryWriter writer = new BinaryWriter(ms);
                writer.Write(reader.ReadBytes(messageLen));
                ms.Seek(0, SeekOrigin.Begin);
                OnReceivedMessage(ms);
            } else {
                //Back up the position two bytes
                memStream.Position = memStream.Position - 2;
                break;
            }
        }
        //Create a new stream with any leftover bytes
        byte[] leftover = reader.ReadBytes((int)RemainingBytes());
        memStream.SetLength(0);     //Clear
        memStream.Write(leftover, 0, leftover.Length);
    }

    /// <summary>
    /// 剩余的字节
    /// </summary>
    private long RemainingBytes() {
        return memStream.Length - memStream.Position;
    }

    /// <summary>
    /// 接收到消息
    /// </summary>
    /// <param name="ms"></param>
    void OnReceivedMessage(MemoryStream ms) {
        BinaryReader r = new BinaryReader(ms);
        byte[] message = r.ReadBytes((int)(ms.Length - ms.Position));
        //int msglen = message.Length;

        ByteBuffer buffer = new ByteBuffer(message);
        int mainId = buffer.ReadShort();
        lock(NetworkManager.sEvents)
        {
            NetworkManager.AddEvent(mainId, buffer);
        }
    }


    /// <summary>
    /// 会话发送
    /// </summary>
    void SessionSend(byte[] bytes) {
        WriteMessage(bytes);
    }

    /// <summary>
    /// 关闭链接
    /// </summary>
    public void Close() {
        if (client != null) {
            if (client.Connected) client.Close();
            client = null;
        }
        loggedIn = false;
    }

    /// <summary>
    /// 发送连接请求
    /// </summary>
    public void SendConnect() {
        ConnectServer(AppConst.SocketAddress, AppConst.SocketPort);
    }

    /// <summary>
    /// 发送消息
    /// </summary>
    public void SendMessage(ByteBuffer buffer) {
        SessionSend(buffer.ToBytes());
        buffer.Close();
    }

    public void OnDestory()
    {
        thread.Abort();
        thread = null;
    }
}
