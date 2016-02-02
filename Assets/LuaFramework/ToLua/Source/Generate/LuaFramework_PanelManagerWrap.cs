using System;
using LuaInterface;

public class LuaFramework_PanelManagerWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(LuaFramework.PanelManager), typeof(Manager));
		L.RegFunction("CreatePanel", CreatePanel);
		L.RegFunction("New", _CreateLuaFramework_PanelManager);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", Lua_ToString);
		L.RegVar("out", get_out, null);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateLuaFramework_PanelManager(IntPtr L)
	{
		return LuaDLL.luaL_error(L, "LuaFramework.PanelManager class does not have a constructor function");
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CreatePanel(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 3);
		LuaFramework.PanelManager obj = (LuaFramework.PanelManager)ToLua.CheckObject(L, 1, typeof(LuaFramework.PanelManager));
		string arg0 = ToLua.CheckString(L, 2);
		LuaFunction arg1 = ToLua.CheckLuaFunction(L, 3);

		try
		{
			obj.CreatePanel(arg0, arg1);
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
		ToLua.PushOut<LuaFramework.PanelManager>(L, new LuaOut<LuaFramework.PanelManager>());
		return 1;
	}
}

