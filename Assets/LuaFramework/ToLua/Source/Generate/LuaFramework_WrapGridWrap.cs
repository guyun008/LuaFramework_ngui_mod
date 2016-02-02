using System;
using LuaInterface;

public class LuaFramework_WrapGridWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(LuaFramework.WrapGrid), typeof(UnityEngine.MonoBehaviour));
		L.RegFunction("InitGrid", InitGrid);
		L.RegFunction("New", _CreateLuaFramework_WrapGrid);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", Lua_ToString);
		L.RegVar("out", get_out, null);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateLuaFramework_WrapGrid(IntPtr L)
	{
		return LuaDLL.luaL_error(L, "LuaFramework.WrapGrid class does not have a constructor function");
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int InitGrid(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 1);
		LuaFramework.WrapGrid obj = (LuaFramework.WrapGrid)ToLua.CheckObject(L, 1, typeof(LuaFramework.WrapGrid));

		try
		{
			obj.InitGrid();
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
		ToLua.PushOut<LuaFramework.WrapGrid>(L, new LuaOut<LuaFramework.WrapGrid>());
		return 1;
	}
}

