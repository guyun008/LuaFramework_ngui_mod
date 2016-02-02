using System;
using LuaInterface;

public class LuaFramework_UtilWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(LuaFramework.Util), typeof(System.Object));
		L.RegFunction("Int", Int);
		L.RegFunction("Float", Float);
		L.RegFunction("Long", Long);
		L.RegFunction("Random", Random);
		L.RegFunction("Uid", Uid);
		L.RegFunction("GetTime", GetTime);
		L.RegFunction("Child", Child);
		L.RegFunction("Peer", Peer);
		L.RegFunction("Vibrate", Vibrate);
		L.RegFunction("Encode", Encode);
		L.RegFunction("Decode", Decode);
		L.RegFunction("IsNumeric", IsNumeric);
		L.RegFunction("HashToMD5Hex", HashToMD5Hex);
		L.RegFunction("md5", md5);
		L.RegFunction("md5file", md5file);
		L.RegFunction("ClearChild", ClearChild);
		L.RegFunction("GetKey", GetKey);
		L.RegFunction("GetInt", GetInt);
		L.RegFunction("HasKey", HasKey);
		L.RegFunction("SetInt", SetInt);
		L.RegFunction("GetString", GetString);
		L.RegFunction("SetString", SetString);
		L.RegFunction("RemoveData", RemoveData);
		L.RegFunction("ClearMemory", ClearMemory);
		L.RegFunction("IsNumber", IsNumber);
		L.RegFunction("GetFileText", GetFileText);
		L.RegFunction("AppContentPath", AppContentPath);
		L.RegFunction("AddClick", AddClick);
		L.RegFunction("LuaPath", LuaPath);
		L.RegFunction("SearchLuaPath", SearchLuaPath);
		L.RegFunction("AddLuaPath", AddLuaPath);
		L.RegFunction("RemoveLuaPath", RemoveLuaPath);
		L.RegFunction("Log", Log);
		L.RegFunction("LogWarning", LogWarning);
		L.RegFunction("LogError", LogError);
		L.RegFunction("LoadAsset", LoadAsset);
		L.RegFunction("AddComponent", AddComponent);
		L.RegFunction("LoadPrefab", LoadPrefab);
		L.RegFunction("CallMethod", CallMethod);
		L.RegFunction("CheckEnvironment", CheckEnvironment);
		L.RegFunction("New", _CreateLuaFramework_Util);
		L.RegFunction("__tostring", Lua_ToString);
		L.RegVar("DataPath", get_DataPath, null);
		L.RegVar("NetAvailable", get_NetAvailable, null);
		L.RegVar("IsWifi", get_IsWifi, null);
		L.RegVar("isLogin", get_isLogin, null);
		L.RegVar("isMain", get_isMain, null);
		L.RegVar("isFight", get_isFight, null);
		L.RegVar("isApplePlatform", get_isApplePlatform, null);
		L.RegVar("out", get_out, null);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateLuaFramework_Util(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 0)
		{
			LuaFramework.Util obj = new LuaFramework.Util();
			ToLua.PushObject(L, obj);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: LuaFramework.Util.New");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Int(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 1);
		object arg0 = ToLua.ToVarObject(L, 1);
		int o;

		try
		{
			o = LuaFramework.Util.Int(arg0);
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		LuaDLL.lua_pushinteger(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Float(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 1);
		object arg0 = ToLua.ToVarObject(L, 1);
		float o;

		try
		{
			o = LuaFramework.Util.Float(arg0);
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		LuaDLL.lua_pushnumber(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Long(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 1);
		object arg0 = ToLua.ToVarObject(L, 1);
		long o;

		try
		{
			o = LuaFramework.Util.Long(arg0);
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		LuaDLL.lua_pushnumber(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Random(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 2 && ToLua.CheckTypes(L, 1, typeof(float), typeof(float)))
		{
			float arg0 = (float)LuaDLL.lua_tonumber(L, 1);
			float arg1 = (float)LuaDLL.lua_tonumber(L, 2);
			float o;

			try
			{
				o = LuaFramework.Util.Random(arg0, arg1);
			}
			catch(Exception e)
			{
				return LuaDLL.luaL_error(L, e.Message);
			}

			LuaDLL.lua_pushnumber(L, o);
			return 1;
		}
		else if (count == 2 && ToLua.CheckTypes(L, 1, typeof(int), typeof(int)))
		{
			int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
			int arg1 = (int)LuaDLL.lua_tonumber(L, 2);
			int o;

			try
			{
				o = LuaFramework.Util.Random(arg0, arg1);
			}
			catch(Exception e)
			{
				return LuaDLL.luaL_error(L, e.Message);
			}

			LuaDLL.lua_pushinteger(L, o);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: LuaFramework.Util.Random");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Uid(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 1);
		string arg0 = ToLua.CheckString(L, 1);
		string o = null;

		try
		{
			o = LuaFramework.Util.Uid(arg0);
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		LuaDLL.lua_pushstring(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetTime(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 0);
		long o;

		try
		{
			o = LuaFramework.Util.GetTime();
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		LuaDLL.lua_pushnumber(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Child(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 2 && ToLua.CheckTypes(L, 1, typeof(UnityEngine.Transform), typeof(string)))
		{
			UnityEngine.Transform arg0 = (UnityEngine.Transform)ToLua.ToObject(L, 1);
			string arg1 = ToLua.ToString(L, 2);
			UnityEngine.GameObject o = null;

			try
			{
				o = LuaFramework.Util.Child(arg0, arg1);
			}
			catch(Exception e)
			{
				return LuaDLL.luaL_error(L, e.Message);
			}

			ToLua.Push(L, o);
			return 1;
		}
		else if (count == 2 && ToLua.CheckTypes(L, 1, typeof(UnityEngine.GameObject), typeof(string)))
		{
			UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.ToObject(L, 1);
			string arg1 = ToLua.ToString(L, 2);
			UnityEngine.GameObject o = null;

			try
			{
				o = LuaFramework.Util.Child(arg0, arg1);
			}
			catch(Exception e)
			{
				return LuaDLL.luaL_error(L, e.Message);
			}

			ToLua.Push(L, o);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: LuaFramework.Util.Child");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Peer(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 2 && ToLua.CheckTypes(L, 1, typeof(UnityEngine.Transform), typeof(string)))
		{
			UnityEngine.Transform arg0 = (UnityEngine.Transform)ToLua.ToObject(L, 1);
			string arg1 = ToLua.ToString(L, 2);
			UnityEngine.GameObject o = null;

			try
			{
				o = LuaFramework.Util.Peer(arg0, arg1);
			}
			catch(Exception e)
			{
				return LuaDLL.luaL_error(L, e.Message);
			}

			ToLua.Push(L, o);
			return 1;
		}
		else if (count == 2 && ToLua.CheckTypes(L, 1, typeof(UnityEngine.GameObject), typeof(string)))
		{
			UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.ToObject(L, 1);
			string arg1 = ToLua.ToString(L, 2);
			UnityEngine.GameObject o = null;

			try
			{
				o = LuaFramework.Util.Peer(arg0, arg1);
			}
			catch(Exception e)
			{
				return LuaDLL.luaL_error(L, e.Message);
			}

			ToLua.Push(L, o);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: LuaFramework.Util.Peer");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Vibrate(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 0);

		try
		{
			LuaFramework.Util.Vibrate();
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Encode(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 1);
		string arg0 = ToLua.CheckString(L, 1);
		string o = null;

		try
		{
			o = LuaFramework.Util.Encode(arg0);
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		LuaDLL.lua_pushstring(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Decode(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 1);
		string arg0 = ToLua.CheckString(L, 1);
		string o = null;

		try
		{
			o = LuaFramework.Util.Decode(arg0);
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		LuaDLL.lua_pushstring(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IsNumeric(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 1);
		string arg0 = ToLua.CheckString(L, 1);
		bool o;

		try
		{
			o = LuaFramework.Util.IsNumeric(arg0);
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		LuaDLL.lua_pushboolean(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int HashToMD5Hex(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 1);
		string arg0 = ToLua.CheckString(L, 1);
		string o = null;

		try
		{
			o = LuaFramework.Util.HashToMD5Hex(arg0);
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		LuaDLL.lua_pushstring(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int md5(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 1);
		string arg0 = ToLua.CheckString(L, 1);
		string o = null;

		try
		{
			o = LuaFramework.Util.md5(arg0);
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		LuaDLL.lua_pushstring(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int md5file(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 1);
		string arg0 = ToLua.CheckString(L, 1);
		string o = null;

		try
		{
			o = LuaFramework.Util.md5file(arg0);
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		LuaDLL.lua_pushstring(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ClearChild(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 1);
		UnityEngine.Transform arg0 = (UnityEngine.Transform)ToLua.CheckUnityObject(L, 1, typeof(UnityEngine.Transform));

		try
		{
			LuaFramework.Util.ClearChild(arg0);
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetKey(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 1);
		string arg0 = ToLua.CheckString(L, 1);
		string o = null;

		try
		{
			o = LuaFramework.Util.GetKey(arg0);
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		LuaDLL.lua_pushstring(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetInt(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 1);
		string arg0 = ToLua.CheckString(L, 1);
		int o;

		try
		{
			o = LuaFramework.Util.GetInt(arg0);
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		LuaDLL.lua_pushinteger(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int HasKey(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 1);
		string arg0 = ToLua.CheckString(L, 1);
		bool o;

		try
		{
			o = LuaFramework.Util.HasKey(arg0);
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		LuaDLL.lua_pushboolean(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetInt(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 2);
		string arg0 = ToLua.CheckString(L, 1);
		int arg1 = (int)LuaDLL.luaL_checknumber(L, 2);

		try
		{
			LuaFramework.Util.SetInt(arg0, arg1);
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetString(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 1);
		string arg0 = ToLua.CheckString(L, 1);
		string o = null;

		try
		{
			o = LuaFramework.Util.GetString(arg0);
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		LuaDLL.lua_pushstring(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetString(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 2);
		string arg0 = ToLua.CheckString(L, 1);
		string arg1 = ToLua.CheckString(L, 2);

		try
		{
			LuaFramework.Util.SetString(arg0, arg1);
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RemoveData(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 1);
		string arg0 = ToLua.CheckString(L, 1);

		try
		{
			LuaFramework.Util.RemoveData(arg0);
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ClearMemory(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 0);

		try
		{
			LuaFramework.Util.ClearMemory();
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IsNumber(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 1);
		string arg0 = ToLua.CheckString(L, 1);
		bool o;

		try
		{
			o = LuaFramework.Util.IsNumber(arg0);
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		LuaDLL.lua_pushboolean(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetFileText(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 1);
		string arg0 = ToLua.CheckString(L, 1);
		string o = null;

		try
		{
			o = LuaFramework.Util.GetFileText(arg0);
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		LuaDLL.lua_pushstring(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AppContentPath(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 0);
		string o = null;

		try
		{
			o = LuaFramework.Util.AppContentPath();
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		LuaDLL.lua_pushstring(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AddClick(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 2);
		UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.CheckUnityObject(L, 1, typeof(UnityEngine.GameObject));
		object arg1 = ToLua.ToVarObject(L, 2);

		try
		{
			LuaFramework.Util.AddClick(arg0, arg1);
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LuaPath(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 1);
		string arg0 = ToLua.CheckString(L, 1);
		string o = null;

		try
		{
			o = LuaFramework.Util.LuaPath(arg0);
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		LuaDLL.lua_pushstring(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SearchLuaPath(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 1);
		string arg0 = ToLua.CheckString(L, 1);
		string o = null;

		try
		{
			o = LuaFramework.Util.SearchLuaPath(arg0);
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		LuaDLL.lua_pushstring(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AddLuaPath(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 1);
		string arg0 = ToLua.CheckString(L, 1);

		try
		{
			LuaFramework.Util.AddLuaPath(arg0);
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RemoveLuaPath(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 1);
		string arg0 = ToLua.CheckString(L, 1);

		try
		{
			LuaFramework.Util.RemoveLuaPath(arg0);
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Log(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 1);
		string arg0 = ToLua.CheckString(L, 1);

		try
		{
			LuaFramework.Util.Log(arg0);
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LogWarning(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 1);
		string arg0 = ToLua.CheckString(L, 1);

		try
		{
			LuaFramework.Util.LogWarning(arg0);
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LogError(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 1);
		string arg0 = ToLua.CheckString(L, 1);

		try
		{
			LuaFramework.Util.LogError(arg0);
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
		UnityEngine.AssetBundle arg0 = (UnityEngine.AssetBundle)ToLua.CheckUnityObject(L, 1, typeof(UnityEngine.AssetBundle));
		string arg1 = ToLua.CheckString(L, 2);
		UnityEngine.GameObject o = null;

		try
		{
			o = LuaFramework.Util.LoadAsset(arg0, arg1);
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		ToLua.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AddComponent(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 3);
		UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.CheckUnityObject(L, 1, typeof(UnityEngine.GameObject));
		string arg1 = ToLua.CheckString(L, 2);
		string arg2 = ToLua.CheckString(L, 3);
		UnityEngine.Component o = null;

		try
		{
			o = LuaFramework.Util.AddComponent(arg0, arg1, arg2);
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		ToLua.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LoadPrefab(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 1);
		string arg0 = ToLua.CheckString(L, 1);
		UnityEngine.GameObject o = null;

		try
		{
			o = LuaFramework.Util.LoadPrefab(arg0);
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		ToLua.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CallMethod(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);
		string arg0 = ToLua.CheckString(L, 1);
		string arg1 = ToLua.CheckString(L, 2);
		object[] arg2 = ToLua.ToParamsObject(L, 3, count - 2);
		object[] o = null;

		try
		{
			o = LuaFramework.Util.CallMethod(arg0, arg1, arg2);
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		ToLua.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CheckEnvironment(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 0);
		bool o;

		try
		{
			o = LuaFramework.Util.CheckEnvironment();
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
	static int get_DataPath(IntPtr L)
	{
		LuaDLL.lua_pushstring(L, LuaFramework.Util.DataPath);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_NetAvailable(IntPtr L)
	{
		LuaDLL.lua_pushboolean(L, LuaFramework.Util.NetAvailable);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_IsWifi(IntPtr L)
	{
		LuaDLL.lua_pushboolean(L, LuaFramework.Util.IsWifi);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_isLogin(IntPtr L)
	{
		LuaDLL.lua_pushboolean(L, LuaFramework.Util.isLogin);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_isMain(IntPtr L)
	{
		LuaDLL.lua_pushboolean(L, LuaFramework.Util.isMain);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_isFight(IntPtr L)
	{
		LuaDLL.lua_pushboolean(L, LuaFramework.Util.isFight);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_isApplePlatform(IntPtr L)
	{
		LuaDLL.lua_pushboolean(L, LuaFramework.Util.isApplePlatform);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_out(IntPtr L)
	{
		ToLua.PushOut<LuaFramework.Util>(L, new LuaOut<LuaFramework.Util>());
		return 1;
	}
}

