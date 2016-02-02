using System;
using LuaInterface;

public class LuaFramework_GameManagerWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(LuaFramework.GameManager), typeof(LuaFramework.LuaBehaviour));
		L.RegFunction("InitGui", InitGui);
		L.RegFunction("CheckExtractResource", CheckExtractResource);
		L.RegFunction("OnResourceInited", OnResourceInited);
		L.RegFunction("New", _CreateLuaFramework_GameManager);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", Lua_ToString);
		L.RegVar("out", get_out, null);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateLuaFramework_GameManager(IntPtr L)
	{
		return LuaDLL.luaL_error(L, "LuaFramework.GameManager class does not have a constructor function");
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int InitGui(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 1);
		LuaFramework.GameManager obj = (LuaFramework.GameManager)ToLua.CheckObject(L, 1, typeof(LuaFramework.GameManager));

		try
		{
			obj.InitGui();
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CheckExtractResource(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 1);
		LuaFramework.GameManager obj = (LuaFramework.GameManager)ToLua.CheckObject(L, 1, typeof(LuaFramework.GameManager));

		try
		{
			obj.CheckExtractResource();
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnResourceInited(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 1);
		LuaFramework.GameManager obj = (LuaFramework.GameManager)ToLua.CheckObject(L, 1, typeof(LuaFramework.GameManager));

		try
		{
			obj.OnResourceInited();
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
		ToLua.PushOut<LuaFramework.GameManager>(L, new LuaOut<LuaFramework.GameManager>());
		return 1;
	}
}

