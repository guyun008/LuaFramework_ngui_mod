using System;
using LuaInterface;

public class LuaFramework_LuaManagerWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(LuaFramework.LuaManager), typeof(Manager));
		L.RegFunction("InitStart", InitStart);
		L.RegFunction("DoFile", DoFile);
		L.RegFunction("CallFunction", CallFunction);
		L.RegFunction("LuaGC", LuaGC);
		L.RegFunction("Close", Close);
		L.RegFunction("New", _CreateLuaFramework_LuaManager);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", Lua_ToString);
		L.RegVar("out", get_out, null);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateLuaFramework_LuaManager(IntPtr L)
	{
		return LuaDLL.luaL_error(L, "LuaFramework.LuaManager class does not have a constructor function");
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int InitStart(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 1);
		LuaFramework.LuaManager obj = (LuaFramework.LuaManager)ToLua.CheckObject(L, 1, typeof(LuaFramework.LuaManager));

		try
		{
			obj.InitStart();
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int DoFile(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 2);
		LuaFramework.LuaManager obj = (LuaFramework.LuaManager)ToLua.CheckObject(L, 1, typeof(LuaFramework.LuaManager));
		string arg0 = ToLua.CheckString(L, 2);
		object[] o = null;

		try
		{
			o = obj.DoFile(arg0);
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		ToLua.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CallFunction(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);
		LuaFramework.LuaManager obj = (LuaFramework.LuaManager)ToLua.CheckObject(L, 1, typeof(LuaFramework.LuaManager));
		string arg0 = ToLua.CheckString(L, 2);
		object[] arg1 = ToLua.ToParamsObject(L, 3, count - 2);
		object[] o = null;

		try
		{
			o = obj.CallFunction(arg0, arg1);
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		ToLua.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LuaGC(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 1);
		LuaFramework.LuaManager obj = (LuaFramework.LuaManager)ToLua.CheckObject(L, 1, typeof(LuaFramework.LuaManager));

		try
		{
			obj.LuaGC();
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Close(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 1);
		LuaFramework.LuaManager obj = (LuaFramework.LuaManager)ToLua.CheckObject(L, 1, typeof(LuaFramework.LuaManager));

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
		ToLua.PushOut<LuaFramework.LuaManager>(L, new LuaOut<LuaFramework.LuaManager>());
		return 1;
	}
}

