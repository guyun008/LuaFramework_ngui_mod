using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using LuaInterface;

namespace LuaFramework {
    public class NetworkManager : Manager {
        private SocketClient socket;
        public static Queue<KeyValuePair<int, ByteBuffer>> sEvents = new Queue<KeyValuePair<int, ByteBuffer>>();
        public static Queue<ByteBuffer> toSendBuffers = new Queue<ByteBuffer>();

        SocketClient SocketClient {
            get {
                if (socket == null)
                    socket = new SocketClient();
                return socket;                    
            }
        }

        void Awake() {
            Init();
        }

        void Init() {
            Debug.Log("init socket!");
            //SocketClient.OnRegister();
            SocketClient.init();
        }

        public void OnInit() {
            CallMethod("Start");
        }

        public void Unload() {
            CallMethod("Unload");
        }

        /// <summary>
        /// 执行Lua方法
        /// </summary>
        public object[] CallMethod(string func, params object[] args) {
            return Util.CallMethod("Network", func, args);
        }

        ///------------------------------------------------------------------------------------
        public static void AddEvent(int _event, ByteBuffer data) {
            lock(sEvents)
            {
                sEvents.Enqueue(new KeyValuePair<int, ByteBuffer>(_event, data));
            }
        }

        /// <summary>
        /// 处理接收到的消息，交给Command，这里不想关心发给谁。
        /// </summary>
        void Update() {
            if (sEvents.Count > 0) {
                lock(sEvents)
                {
                    while (sEvents.Count > 0)
                    {
                        KeyValuePair<int, ByteBuffer> _event = sEvents.Dequeue();
                        facade.SendMessageCommand(NotiConst.DISPATCH_NET_MESSAGE, _event);
                    }
                }
            }
        }

        /// <summary>
        /// 发送链接请求
        /// </summary>
        public void SendConnect() {
            SocketClient.sockteClientState = SocketClient.netState.ToConnect;
            Debug.Log("connect server!"); 
        }

        /// <summary>
        /// 发送SOCKET消息
        /// </summary>
        public void SendMessage(ByteBuffer buffer) {
            lock(toSendBuffers)
            {
                toSendBuffers.Enqueue(buffer);
            }
            //SocketClient.SendMessage(buffer);
        }

        /// <summary>
        /// 析构函数
        /// </summary>
        new void OnDestroy() {
            //SocketClient.OnRemove();
            SocketClient.sockteClientState = SocketClient.netState.ToDisconnect;
            Debug.Log("~NetworkManager was destroy");
            socket.Close();
            socket.OnDestory();
            socket = null;
        }
    }
}