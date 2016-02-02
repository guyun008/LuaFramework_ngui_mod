using System;
using LuaInterface;

public class LuaFramework_ByteBufferWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(LuaFramework.ByteBuffer), typeof(System.Object));
		L.RegFunction("Close", Close);
		L.RegFunction("WriteByte", WriteByte);
		L.RegFunction("WriteInt", WriteInt);
		L.RegFunction("WriteShort", WriteShort);
		L.RegFunction("WriteLong", WriteLong);
		L.RegFunction("WriteFloat", WriteFloat);
		L.RegFunction("WriteDouble", WriteDouble);
		L.RegFunction("WriteString", WriteString);
		L.RegFunction("WriteBytes", WriteBytes);
		L.RegFunction("ReadByte", ReadByte);
		L.RegFunction("ReadInt", ReadInt);
		L.RegFunction("ReadShort", ReadShort);
		L.RegFunction("ReadLong", ReadLong);
		L.RegFunction("ReadFloat", ReadFloat);
		L.RegFunction("ReadDouble", ReadDouble);
		L.RegFunction("ReadString", ReadString);
		L.RegFunction("ReadBytes", ReadBytes);
		L.RegFunction("ToBytes", ToBytes);
		L.RegFunction("Flush", Flush);
		L.RegFunction("New", _CreateLuaFramework_ByteBuffer);
		L.RegFunction("__tostring", Lua_ToString);
		L.RegVar("out", get_out, null);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateLuaFramework_ByteBuffer(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 0)
		{
			LuaFramework.ByteBuffer obj = new LuaFramework.ByteBuffer();
			ToLua.PushObject(L, obj);
			return 1;
		}
		else if (count == 1 && ToLua.CheckTypes(L, 1, typeof(byte[])))
		{
			byte[] arg0 = ToLua.CheckByteBuffer(L, 1);
			LuaFramework.ByteBuffer obj = new LuaFramework.ByteBuffer(arg0);
			ToLua.PushObject(L, obj);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: LuaFramework.ByteBuffer.New");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Close(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 1);
		LuaFramework.ByteBuffer obj = (LuaFramework.ByteBuffer)ToLua.CheckObject(L, 1, typeof(LuaFramework.ByteBuffer));

		try
		{
			obj.Close();
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int WriteByte(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 2);
		LuaFramework.ByteBuffer obj = (LuaFramework.ByteBuffer)ToLua.CheckObject(L, 1, typeof(LuaFramework.ByteBuffer));
		byte arg0 = (byte)LuaDLL.luaL_checknumber(L, 2);

		try
		{
			obj.WriteByte(arg0);
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int WriteInt(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 2);
		LuaFramework.ByteBuffer obj = (LuaFramework.ByteBuffer)ToLua.CheckObject(L, 1, typeof(LuaFramework.ByteBuffer));
		int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);

		try
		{
			obj.WriteInt(arg0);
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int WriteShort(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 2);
		LuaFramework.ByteBuffer obj = (LuaFramework.ByteBuffer)ToLua.CheckObject(L, 1, typeof(LuaFramework.ByteBuffer));
		ushort arg0 = (ushort)LuaDLL.luaL_checknumber(L, 2);

		try
		{
			obj.WriteShort(arg0);
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int WriteLong(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 2);
		LuaFramework.ByteBuffer obj = (LuaFramework.ByteBuffer)ToLua.CheckObject(L, 1, typeof(LuaFramework.ByteBuffer));
		long arg0 = (long)LuaDLL.luaL_checknumber(L, 2);

		try
		{
			obj.WriteLong(arg0);
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int WriteFloat(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 2);
		LuaFramework.ByteBuffer obj = (LuaFramework.ByteBuffer)ToLua.CheckObject(L, 1, typeof(LuaFramework.ByteBuffer));
		float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);

		try
		{
			obj.WriteFloat(arg0);
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int WriteDouble(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 2);
		LuaFramework.ByteBuffer obj = (LuaFramework.ByteBuffer)ToLua.CheckObject(L, 1, typeof(LuaFramework.ByteBuffer));
		double arg0 = (double)LuaDLL.luaL_checknumber(L, 2);

		try
		{
			obj.WriteDouble(arg0);
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int WriteString(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 2);
		LuaFramework.ByteBuffer obj = (LuaFramework.ByteBuffer)ToLua.CheckObject(L, 1, typeof(LuaFramework.ByteBuffer));
		string arg0 = ToLua.CheckString(L, 2);

		try
		{
			obj.WriteString(arg0);
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int WriteBytes(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 2);
		LuaFramework.ByteBuffer obj = (LuaFramework.ByteBuffer)ToLua.CheckObject(L, 1, typeof(LuaFramework.ByteBuffer));
		byte[] arg0 = ToLua.CheckByteBuffer(L, 2);

		try
		{
			obj.WriteBytes(arg0);
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ReadByte(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 1);
		LuaFramework.ByteBuffer obj = (LuaFramework.ByteBuffer)ToLua.CheckObject(L, 1, typeof(LuaFramework.ByteBuffer));
		byte o;

		try
		{
			o = obj.ReadByte();
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		LuaDLL.lua_pushnumber(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ReadInt(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 1);
		LuaFramework.ByteBuffer obj = (LuaFramework.ByteBuffer)ToLua.CheckObject(L, 1, typeof(LuaFramework.ByteBuffer));
		int o;

		try
		{
			o = obj.ReadInt();
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		LuaDLL.lua_pushinteger(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ReadShort(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 1);
		LuaFramework.ByteBuffer obj = (LuaFramework.ByteBuffer)ToLua.CheckObject(L, 1, typeof(LuaFramework.ByteBuffer));
		ushort o;

		try
		{
			o = obj.ReadShort();
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		LuaDLL.lua_pushnumber(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ReadLong(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 1);
		LuaFramework.ByteBuffer obj = (LuaFramework.ByteBuffer)ToLua.CheckObject(L, 1, typeof(LuaFramework.ByteBuffer));
		long o;

		try
		{
			o = obj.ReadLong();
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		LuaDLL.lua_pushnumber(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ReadFloat(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 1);
		LuaFramework.ByteBuffer obj = (LuaFramework.ByteBuffer)ToLua.CheckObject(L, 1, typeof(LuaFramework.ByteBuffer));
		float o;

		try
		{
			o = obj.ReadFloat();
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		LuaDLL.lua_pushnumber(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ReadDouble(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 1);
		LuaFramework.ByteBuffer obj = (LuaFramework.ByteBuffer)ToLua.CheckObject(L, 1, typeof(LuaFramework.ByteBuffer));
		double o;

		try
		{
			o = obj.ReadDouble();
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		LuaDLL.lua_pushnumber(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ReadString(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 1);
		LuaFramework.ByteBuffer obj = (LuaFramework.ByteBuffer)ToLua.CheckObject(L, 1, typeof(LuaFramework.ByteBuffer));
		string o = null;

		try
		{
			o = obj.ReadString();
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		LuaDLL.lua_pushstring(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ReadBytes(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 1);
		LuaFramework.ByteBuffer obj = (LuaFramework.ByteBuffer)ToLua.CheckObject(L, 1, typeof(LuaFramework.ByteBuffer));
		byte[] o = null;

		try
		{
			o = obj.ReadBytes();
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		ToLua.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ToBytes(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 1);
		LuaFramework.ByteBuffer obj = (LuaFramework.ByteBuffer)ToLua.CheckObject(L, 1, typeof(LuaFramework.ByteBuffer));
		byte[] o = null;

		try
		{
			o = obj.ToBytes();
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		ToLua.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Flush(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 1);
		LuaFramework.ByteBuffer obj = (LuaFramework.ByteBuffer)ToLua.CheckObject(L, 1, typeof(LuaFramework.ByteBuffer));

		try
		{
			obj.Flush();
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Lua_ToString(IntPtr L)
	{
		object obj = ToLua.ToObject(L, 1);

		if (obj != null)
		{
			LuaDLL.lua_pushstring(L, obj.ToString());
		}
		else
		{
			LuaDLL.lua_pushnil(L);
		}

		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_out(IntPtr L)
	{
		ToLua.PushOut<LuaFramework.ByteBuffer>(L, new LuaOut<LuaFramework.ByteBuffer>());
		return 1;
	}
}

