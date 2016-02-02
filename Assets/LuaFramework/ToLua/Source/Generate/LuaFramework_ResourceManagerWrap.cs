using System;
using LuaInterface;

public class LuaFramework_ResourceManagerWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(LuaFramework.ResourceManager), typeof(Manager));
		L.RegFunction("initialize", initialize);
		L.RegFunction("LoadBundle", LoadBundle);
		L.RegFunction("New", _CreateLuaFramework_ResourceManager);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", Lua_ToString);
		L.RegVar("out", get_out, null);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateLuaFramework_ResourceManager(IntPtr L)
	{
		return LuaDLL.luaL_error(L, "LuaFramework.ResourceManager class does not have a constructor function");
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int initialize(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 2);
		LuaFramework.ResourceManager obj = (LuaFramework.ResourceManager)ToLua.CheckObject(L, 1, typeof(LuaFramework.ResourceManager));
		System.Action arg0 = null;
		LuaTypes funcType2 = LuaDLL.lua_type(L, 2);

		if (funcType2 != LuaTypes.LUA_TFUNCTION)
		{
			 arg0 = (System.Action)ToLua.CheckObject(L, 2, typeof(System.Action));
		}
		else
		{
			LuaFunction func = ToLua.ToLuaFunction(L, 2);
			arg0 = DelegateFactory.CreateDelegate(L, typeof(System.Action), func) as System.Action;
		}

		try
		{
			obj.initialize(arg0);
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LoadBundle(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 2);
		LuaFramework.ResourceManager obj = (LuaFramework.ResourceManager)ToLua.CheckObject(L, 1, typeof(LuaFramework.ResourceManager));
		string arg0 = ToLua.CheckString(L, 2);
		UnityEngine.AssetBundle o = null;

		try
		{
			o = obj.LoadBundle(arg0);
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		ToLua.Push(L, o);
		return 1;
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
		ToLua.PushOut<LuaFramework.ResourceManager>(L, new LuaOut<LuaFramework.ResourceManager>());
		return 1;
	}
}

