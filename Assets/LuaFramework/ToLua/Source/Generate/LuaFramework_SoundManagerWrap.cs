using System;
using LuaInterface;

public class LuaFramework_SoundManagerWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(LuaFramework.SoundManager), typeof(Manager));
		L.RegFunction("LoadAudioClip", LoadAudioClip);
		L.RegFunction("CanPlayBackSound", CanPlayBackSound);
		L.RegFunction("PlayBacksound", PlayBacksound);
		L.RegFunction("CanPlaySoundEffect", CanPlaySoundEffect);
		L.RegFunction("Play", Play);
		L.RegFunction("New", _CreateLuaFramework_SoundManager);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", Lua_ToString);
		L.RegVar("out", get_out, null);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateLuaFramework_SoundManager(IntPtr L)
	{
		return LuaDLL.luaL_error(L, "LuaFramework.SoundManager class does not have a constructor function");
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LoadAudioClip(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 2);
		LuaFramework.SoundManager obj = (LuaFramework.SoundManager)ToLua.CheckObject(L, 1, typeof(LuaFramework.SoundManager));
		string arg0 = ToLua.CheckString(L, 2);
		UnityEngine.AudioClip o = null;

		try
		{
			o = obj.LoadAudioClip(arg0);
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		ToLua.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CanPlayBackSound(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 1);
		LuaFramework.SoundManager obj = (LuaFramework.SoundManager)ToLua.CheckObject(L, 1, typeof(LuaFramework.SoundManager));
		bool o;

		try
		{
			o = obj.CanPlayBackSound();
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		LuaDLL.lua_pushboolean(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int PlayBacksound(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 3);
		LuaFramework.SoundManager obj = (LuaFramework.SoundManager)ToLua.CheckObject(L, 1, typeof(LuaFramework.SoundManager));
		string arg0 = ToLua.CheckString(L, 2);
		bool arg1 = LuaDLL.luaL_checkboolean(L, 3);

		try
		{
			obj.PlayBacksound(arg0, arg1);
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CanPlaySoundEffect(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 1);
		LuaFramework.SoundManager obj = (LuaFramework.SoundManager)ToLua.CheckObject(L, 1, typeof(LuaFramework.SoundManager));
		bool o;

		try
		{
			o = obj.CanPlaySoundEffect();
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		LuaDLL.lua_pushboolean(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Play(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 3);
		LuaFramework.SoundManager obj = (LuaFramework.SoundManager)ToLua.CheckObject(L, 1, typeof(LuaFramework.SoundManager));
		UnityEngine.AudioClip arg0 = (UnityEngine.AudioClip)ToLua.CheckUnityObject(L, 2, typeof(UnityEngine.AudioClip));
		UnityEngine.Vector3 arg1 = ToLua.ToVector3(L, 3);

		try
		{
			obj.Play(arg0, arg1);
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
		ToLua.PushOut<LuaFramework.SoundManager>(L, new LuaOut<LuaFramework.SoundManager>());
		return 1;
	}
}

