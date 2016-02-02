using System;
using LuaInterface;

public class LuaFramework_LuaBehaviourWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(LuaFramework.LuaBehaviour), typeof(Base));
		L.RegFunction("OnInit", OnInit);
		L.RegFunction("LoadAsset", LoadAsset);
		L.RegFunction("AddClick", AddClick);
		L.RegFunction("RemoveClick", RemoveClick);
		L.RegFunction("ClearClick", ClearClick);
		L.RegFunction("New", _CreateLuaFramework_LuaBehaviour);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", Lua_ToString);
		L.RegVar("out", get_out, null);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateLuaFramework_LuaBehaviour(IntPtr L)
	{
		return LuaDLL.luaL_error(L, "LuaFramework.LuaBehaviour class does not have a constructor function");
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnInit(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 3);
		LuaFramework.LuaBehaviour obj = (LuaFramework.LuaBehaviour)ToLua.CheckObject(L, 1, typeof(LuaFramework.LuaBehaviour));
		UnityEngine.AssetBundle arg0 = (UnityEngine.AssetBundle)ToLua.CheckUnityObject(L, 2, typeof(UnityEngine.AssetBundle));
		string arg1 = ToLua.CheckString(L, 3);

		try
		{
			obj.OnInit(arg0, arg1);
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LoadAsset(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 2);
		LuaFramework.LuaBehaviour obj = (LuaFramework.LuaBehaviour)ToLua.CheckObject(L, 1, typeof(LuaFramework.LuaBehaviour));
		string arg0 = ToLua.CheckString(L, 2);
		UnityEngine.GameObject o = null;

		try
		{
			o = obj.LoadAsset(arg0);
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		ToLua.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AddClick(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 3);
		LuaFramework.LuaBehaviour obj = (LuaFramework.LuaBehaviour)ToLua.CheckObject(L, 1, typeof(LuaFramework.LuaBehaviour));
		UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.CheckUnityObject(L, 2, typeof(UnityEngine.GameObject));
		LuaFunction arg1 = ToLua.CheckLuaFunction(L, 3);

		try
		{
			obj.AddClick(arg0, arg1);
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RemoveClick(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 2);
		LuaFramework.LuaBehaviour obj = (LuaFramework.LuaBehaviour)ToLua.CheckObject(L, 1, typeof(LuaFramework.LuaBehaviour));
		UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.CheckUnityObject(L, 2, typeof(UnityEngine.GameObject));

		try
		{
			obj.RemoveClick(arg0);
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ClearClick(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 1);
		LuaFramework.LuaBehaviour obj = (LuaFramework.LuaBehaviour)ToLua.CheckObject(L, 1, typeof(LuaFramework.LuaBehaviour));

		try
		{
			obj.ClearClick();
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
		ToLua.PushOut<LuaFramework.LuaBehaviour>(L, new LuaOut<LuaFramework.LuaBehaviour>());
		return 1;
	}
}

