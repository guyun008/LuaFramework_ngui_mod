using System;
using LuaInterface;

public class LuaFramework_ThreadManagerWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(LuaFramework.ThreadManager), typeof(Manager));
		L.RegFunction("AddEvent", AddEvent);
		L.RegFunction("New", _CreateLuaFramework_ThreadManager);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", Lua_ToString);
		L.RegVar("out", get_out, null);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateLuaFramework_ThreadManager(IntPtr L)
	{
		return LuaDLL.luaL_error(L, "LuaFramework.ThreadManager class does not have a constructor function");
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AddEvent(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 3);
		LuaFramework.ThreadManager obj = (LuaFramework.ThreadManager)ToLua.CheckObject(L, 1, typeof(LuaFramework.ThreadManager));
		ThreadEvent arg0 = (ThreadEvent)ToLua.CheckObject(L, 2, typeof(ThreadEvent));
		System.Action<NotiData> arg1 = null;
		LuaTypes funcType3 = LuaDLL.lua_type(L, 3);

		if (funcType3 != LuaTypes.LUA_TFUNCTION)
		{
			 arg1 = (System.Action<NotiData>)ToLua.CheckObject(L, 3, typeof(System.Action<NotiData>));
		}
		else
		{
			LuaFunction func = ToLua.ToLuaFunction(L, 3);
			arg1 = DelegateFactory.CreateDelegate(L, typeof(System.Action<NotiData>), func) as System.Action<NotiData>;
		}

		try
		{
			obj.AddEvent(arg0, arg1);
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
		ToLua.PushOut<LuaFramework.ThreadManager>(L, new LuaOut<LuaFramework.ThreadManager>());
		return 1;
	}
}

