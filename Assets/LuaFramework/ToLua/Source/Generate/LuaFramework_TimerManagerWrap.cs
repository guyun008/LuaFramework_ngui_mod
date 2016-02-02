using System;
using LuaInterface;

public class LuaFramework_TimerManagerWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(LuaFramework.TimerManager), typeof(Manager));
		L.RegFunction("StartTimer", StartTimer);
		L.RegFunction("StopTimer", StopTimer);
		L.RegFunction("AddTimerEvent", AddTimerEvent);
		L.RegFunction("RemoveTimerEvent", RemoveTimerEvent);
		L.RegFunction("StopTimerEvent", StopTimerEvent);
		L.RegFunction("ResumeTimerEvent", ResumeTimerEvent);
		L.RegFunction("New", _CreateLuaFramework_TimerManager);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", Lua_ToString);
		L.RegVar("Interval", get_Interval, set_Interval);
		L.RegVar("out", get_out, null);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateLuaFramework_TimerManager(IntPtr L)
	{
		return LuaDLL.luaL_error(L, "LuaFramework.TimerManager class does not have a constructor function");
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int StartTimer(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 2);
		LuaFramework.TimerManager obj = (LuaFramework.TimerManager)ToLua.CheckObject(L, 1, typeof(LuaFramework.TimerManager));
		float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);

		try
		{
			obj.StartTimer(arg0);
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int StopTimer(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 1);
		LuaFramework.TimerManager obj = (LuaFramework.TimerManager)ToLua.CheckObject(L, 1, typeof(LuaFramework.TimerManager));

		try
		{
			obj.StopTimer();
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AddTimerEvent(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 2);
		LuaFramework.TimerManager obj = (LuaFramework.TimerManager)ToLua.CheckObject(L, 1, typeof(LuaFramework.TimerManager));
		LuaFramework.TimerInfo arg0 = (LuaFramework.TimerInfo)ToLua.CheckObject(L, 2, typeof(LuaFramework.TimerInfo));

		try
		{
			obj.AddTimerEvent(arg0);
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RemoveTimerEvent(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 2);
		LuaFramework.TimerManager obj = (LuaFramework.TimerManager)ToLua.CheckObject(L, 1, typeof(LuaFramework.TimerManager));
		LuaFramework.TimerInfo arg0 = (LuaFramework.TimerInfo)ToLua.CheckObject(L, 2, typeof(LuaFramework.TimerInfo));

		try
		{
			obj.RemoveTimerEvent(arg0);
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int StopTimerEvent(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 2);
		LuaFramework.TimerManager obj = (LuaFramework.TimerManager)ToLua.CheckObject(L, 1, typeof(LuaFramework.TimerManager));
		LuaFramework.TimerInfo arg0 = (LuaFramework.TimerInfo)ToLua.CheckObject(L, 2, typeof(LuaFramework.TimerInfo));

		try
		{
			obj.StopTimerEvent(arg0);
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ResumeTimerEvent(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 2);
		LuaFramework.TimerManager obj = (LuaFramework.TimerManager)ToLua.CheckObject(L, 1, typeof(LuaFramework.TimerManager));
		LuaFramework.TimerInfo arg0 = (LuaFramework.TimerInfo)ToLua.CheckObject(L, 2, typeof(LuaFramework.TimerInfo));

		try
		{
			obj.ResumeTimerEvent(arg0);
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
	static int get_Interval(IntPtr L)
	{
		LuaFramework.TimerManager obj = (LuaFramework.TimerManager)ToLua.ToObject(L, 1);
		float ret;

		try
		{
			ret = obj.Interval;
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, obj == null ? "attempt to index Interval on a nil value" : e.Message);
		}

		LuaDLL.lua_pushnumber(L, ret);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_Interval(IntPtr L)
	{
		LuaFramework.TimerManager obj = (LuaFramework.TimerManager)ToLua.ToObject(L, 1);
		float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);

		try
		{
			obj.Interval = arg0;
		}
		catch(Exception e)
		{
			if (obj == null)
			{
				LuaDLL.luaL_error(L, "attempt to index Interval on a nil value");
			}
			else
			{
				LuaDLL.luaL_error(L, e.Message);
			}
			return 0;
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_out(IntPtr L)
	{
		ToLua.PushOut<LuaFramework.TimerManager>(L, new LuaOut<LuaFramework.TimerManager>());
		return 1;
	}
}

