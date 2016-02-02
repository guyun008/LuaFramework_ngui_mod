using System;
using LuaInterface;

public class LuaFramework_NetworkManagerWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(LuaFramework.NetworkManager), typeof(Manager));
		L.RegFunction("OnInit", OnInit);
		L.RegFunction("Unload", Unload);
		L.RegFunction("CallMethod", CallMethod);
		L.RegFunction("AddEvent", AddEvent);
		L.RegFunction("SendConnect", SendConnect);
		L.RegFunction("SendMessage", SendMessage);
		L.RegFunction("New", _CreateLuaFramework_NetworkManager);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", Lua_ToString);
		L.RegVar("out", get_out, null);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateLuaFramework_NetworkManager(IntPtr L)
	{
		return LuaDLL.luaL_error(L, "LuaFramework.NetworkManager class does not have a constructor function");
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnInit(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 1);
		LuaFramework.NetworkManager obj = (LuaFramework.NetworkManager)ToLua.CheckObject(L, 1, typeof(LuaFramework.NetworkManager));

		try
		{
			obj.OnInit();
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Unload(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 1);
		LuaFramework.NetworkManager obj = (LuaFramework.NetworkManager)ToLua.CheckObject(L, 1, typeof(LuaFramework.NetworkManager));

		try
		{
			obj.Unload();
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CallMethod(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);
		LuaFramework.NetworkManager obj = (LuaFramework.NetworkManager)ToLua.CheckObject(L, 1, typeof(LuaFramework.NetworkManager));
		string arg0 = ToLua.CheckString(L, 2);
		object[] arg1 = ToLua.ToParamsObject(L, 3, count - 2);
		object[] o = null;

		try
		{
			o = obj.CallMethod(arg0, arg1);
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		ToLua.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AddEvent(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 2);
		int arg0 = (int)LuaDLL.luaL_checknumber(L, 1);
		LuaFramework.ByteBuffer arg1 = (LuaFramework.ByteBuffer)ToLua.CheckObject(L, 2, typeof(LuaFramework.ByteBuffer));

		try
		{
			LuaFramework.NetworkManager.AddEvent(arg0, arg1);
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SendConnect(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 1);
		LuaFramework.NetworkManager obj = (LuaFramework.NetworkManager)ToLua.CheckObject(L, 1, typeof(LuaFramework.NetworkManager));

		try
		{
			obj.SendConnect();
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SendMessage(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 2);
		LuaFramework.NetworkManager obj = (LuaFramework.NetworkManager)ToLua.CheckObject(L, 1, typeof(LuaFramework.NetworkManager));
		LuaFramework.ByteBuffer arg0 = (LuaFramework.ByteBuffer)ToLua.CheckObject(L, 2, typeof(LuaFramework.ByteBuffer));

		try
		{
			obj.SendMessage(arg0);
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int op_Equality(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 2);
		UnityEngine.Object arg0 = (UnityEngine.Object)ToLua.ToObject(L, 1);
		UnityEngine.Object arg1 = (UnityEngine.Object)ToLua.ToObject(L, 2);
		bool o;

		try
		{
			o = arg0 == arg1;
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		LuaDLL.lua_pushboolean(L, o);
		return 1;
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
		ToLua.PushOut<LuaFramework.NetworkManager>(L, new LuaOut<LuaFramework.NetworkManager>());
		return 1;
	}
}

