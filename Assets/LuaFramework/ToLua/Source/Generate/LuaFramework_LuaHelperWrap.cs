using System;
using LuaInterface;

public class LuaFramework_LuaHelperWrap
{
	public static void Register(LuaState L)
	{
		L.BeginStaticLibs("LuaHelper");
		L.RegFunction("GetType", GetType);
		L.RegFunction("GetPanelManager", GetPanelManager);
		L.RegFunction("GetResManager", GetResManager);
		L.RegFunction("GetNetManager", GetNetManager);
		L.RegFunction("GetSoundManager", GetSoundManager);
		L.RegFunction("Action", Action);
		L.RegFunction("VoidDelegate", VoidDelegate);
		L.RegFunction("OnJsonCallFunc", OnJsonCallFunc);
		L.EndStaticLibs();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetType(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 1);
		string arg0 = ToLua.CheckString(L, 1);
		System.Type o = null;

		try
		{
			o = LuaFramework.LuaHelper.GetType(arg0);
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		ToLua.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetPanelManager(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 0);
		LuaFramework.PanelManager o = null;

		try
		{
			o = LuaFramework.LuaHelper.GetPanelManager();
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		ToLua.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetResManager(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 0);
		LuaFramework.ResourceManager o = null;

		try
		{
			o = LuaFramework.LuaHelper.GetResManager();
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		ToLua.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetNetManager(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 0);
		LuaFramework.NetworkManager o = null;

		try
		{
			o = LuaFramework.LuaHelper.GetNetManager();
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		ToLua.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetSoundManager(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 0);
		LuaFramework.SoundManager o = null;

		try
		{
			o = LuaFramework.LuaHelper.GetSoundManager();
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		ToLua.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Action(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 1);
		LuaFunction arg0 = ToLua.CheckLuaFunction(L, 1);
		System.Action o = null;

		try
		{
			o = LuaFramework.LuaHelper.Action(arg0);
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		ToLua.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int VoidDelegate(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 1);
		LuaFunction arg0 = ToLua.CheckLuaFunction(L, 1);
		UIEventListener.VoidDelegate o = null;

		try
		{
			o = LuaFramework.LuaHelper.VoidDelegate(arg0);
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		ToLua.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnJsonCallFunc(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 2);
		string arg0 = ToLua.CheckString(L, 1);
		LuaFunction arg1 = ToLua.CheckLuaFunction(L, 2);

		try
		{
			LuaFramework.LuaHelper.OnJsonCallFunc(arg0, arg1);
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		return 0;
	}
}

