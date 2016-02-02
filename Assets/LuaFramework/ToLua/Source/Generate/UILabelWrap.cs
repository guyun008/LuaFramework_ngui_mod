using System;
using LuaInterface;

public class UILabelWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(UILabel), typeof(UIWidget));
		L.RegFunction("GetSides", GetSides);
		L.RegFunction("MarkAsChanged", MarkAsChanged);
		L.RegFunction("ProcessText", ProcessText);
		L.RegFunction("MakePixelPerfect", MakePixelPerfect);
		L.RegFunction("AssumeNaturalSize", AssumeNaturalSize);
		L.RegFunction("GetCharacterIndexAtPosition", GetCharacterIndexAtPosition);
		L.RegFunction("GetWordAtPosition", GetWordAtPosition);
		L.RegFunction("GetWordAtCharacterIndex", GetWordAtCharacterIndex);
		L.RegFunction("GetUrlAtPosition", GetUrlAtPosition);
		L.RegFunction("GetUrlAtCharacterIndex", GetUrlAtCharacterIndex);
		L.RegFunction("GetCharacterIndex", GetCharacterIndex);
		L.RegFunction("PrintOverlay", PrintOverlay);
		L.RegFunction("OnFill", OnFill);
		L.RegFunction("ApplyOffset", ApplyOffset);
		L.RegFunction("ApplyShadow", ApplyShadow);
		L.RegFunction("CalculateOffsetToFit", CalculateOffsetToFit);
		L.RegFunction("SetCurrentProgress", SetCurrentProgress);
		L.RegFunction("SetCurrentPercent", SetCurrentPercent);
		L.RegFunction("SetCurrentSelection", SetCurrentSelection);
		L.RegFunction("Wrap", Wrap);
		L.RegFunction("UpdateNGUIText", UpdateNGUIText);
		L.RegFunction("New", _CreateUILabel);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", Lua_ToString);
		L.RegVar("keepCrispWhenShrunk", get_keepCrispWhenShrunk, set_keepCrispWhenShrunk);
		L.RegVar("isAnchoredHorizontally", get_isAnchoredHorizontally, null);
		L.RegVar("isAnchoredVertically", get_isAnchoredVertically, null);
		L.RegVar("material", get_material, set_material);
		L.RegVar("bitmapFont", get_bitmapFont, set_bitmapFont);
		L.RegVar("trueTypeFont", get_trueTypeFont, set_trueTypeFont);
		L.RegVar("ambigiousFont", get_ambigiousFont, set_ambigiousFont);
		L.RegVar("text", get_text, set_text);
		L.RegVar("defaultFontSize", get_defaultFontSize, null);
		L.RegVar("fontSize", get_fontSize, set_fontSize);
		L.RegVar("fontStyle", get_fontStyle, set_fontStyle);
		L.RegVar("alignment", get_alignment, set_alignment);
		L.RegVar("applyGradient", get_applyGradient, set_applyGradient);
		L.RegVar("gradientTop", get_gradientTop, set_gradientTop);
		L.RegVar("gradientBottom", get_gradientBottom, set_gradientBottom);
		L.RegVar("spacingX", get_spacingX, set_spacingX);
		L.RegVar("spacingY", get_spacingY, set_spacingY);
		L.RegVar("useFloatSpacing", get_useFloatSpacing, set_useFloatSpacing);
		L.RegVar("floatSpacingX", get_floatSpacingX, set_floatSpacingX);
		L.RegVar("floatSpacingY", get_floatSpacingY, set_floatSpacingY);
		L.RegVar("effectiveSpacingY", get_effectiveSpacingY, null);
		L.RegVar("effectiveSpacingX", get_effectiveSpacingX, null);
		L.RegVar("supportEncoding", get_supportEncoding, set_supportEncoding);
		L.RegVar("symbolStyle", get_symbolStyle, set_symbolStyle);
		L.RegVar("overflowMethod", get_overflowMethod, set_overflowMethod);
		L.RegVar("multiLine", get_multiLine, set_multiLine);
		L.RegVar("localCorners", get_localCorners, null);
		L.RegVar("worldCorners", get_worldCorners, null);
		L.RegVar("drawingDimensions", get_drawingDimensions, null);
		L.RegVar("maxLineCount", get_maxLineCount, set_maxLineCount);
		L.RegVar("effectStyle", get_effectStyle, set_effectStyle);
		L.RegVar("effectColor", get_effectColor, set_effectColor);
		L.RegVar("effectDistance", get_effectDistance, set_effectDistance);
		L.RegVar("processedText", get_processedText, null);
		L.RegVar("printedSize", get_printedSize, null);
		L.RegVar("localSize", get_localSize, null);
		L.RegVar("out", get_out, null);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateUILabel(IntPtr L)
	{
		return LuaDLL.luaL_error(L, "UILabel class does not have a constructor function");
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetSides(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 2);
		UILabel obj = (UILabel)ToLua.CheckObject(L, 1, typeof(UILabel));
		UnityEngine.Transform arg0 = (UnityEngine.Transform)ToLua.CheckUnityObject(L, 2, typeof(UnityEngine.Transform));
		UnityEngine.Vector3[] o = null;

		try
		{
			o = obj.GetSides(arg0);
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		ToLua.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int MarkAsChanged(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 1);
		UILabel obj = (UILabel)ToLua.CheckObject(L, 1, typeof(UILabel));

		try
		{
			obj.MarkAsChanged();
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ProcessText(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 1);
		UILabel obj = (UILabel)ToLua.CheckObject(L, 1, typeof(UILabel));

		try
		{
			obj.ProcessText();
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int MakePixelPerfect(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 1);
		UILabel obj = (UILabel)ToLua.CheckObject(L, 1, typeof(UILabel));

		try
		{
			obj.MakePixelPerfect();
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AssumeNaturalSize(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 1);
		UILabel obj = (UILabel)ToLua.CheckObject(L, 1, typeof(UILabel));

		try
		{
			obj.AssumeNaturalSize();
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetCharacterIndexAtPosition(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 3 && ToLua.CheckTypes(L, 1, typeof(UILabel), typeof(UnityEngine.Vector2), typeof(bool)))
		{
			UILabel obj = (UILabel)ToLua.ToObject(L, 1);
			UnityEngine.Vector2 arg0 = ToLua.ToVector2(L, 2);
			bool arg1 = LuaDLL.lua_toboolean(L, 3);
			int o;

			try
			{
				o = obj.GetCharacterIndexAtPosition(arg0, arg1);
			}
			catch(Exception e)
			{
				return LuaDLL.luaL_error(L, e.Message);
			}

			LuaDLL.lua_pushinteger(L, o);
			return 1;
		}
		else if (count == 3 && ToLua.CheckTypes(L, 1, typeof(UILabel), typeof(UnityEngine.Vector3), typeof(bool)))
		{
			UILabel obj = (UILabel)ToLua.ToObject(L, 1);
			UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
			bool arg1 = LuaDLL.lua_toboolean(L, 3);
			int o;

			try
			{
				o = obj.GetCharacterIndexAtPosition(arg0, arg1);
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
			LuaDLL.luaL_error(L, "invalid arguments to method: UILabel.GetCharacterIndexAtPosition");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetWordAtPosition(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 2 && ToLua.CheckTypes(L, 1, typeof(UILabel), typeof(UnityEngine.Vector2)))
		{
			UILabel obj = (UILabel)ToLua.ToObject(L, 1);
			UnityEngine.Vector2 arg0 = ToLua.ToVector2(L, 2);
			string o = null;

			try
			{
				o = obj.GetWordAtPosition(arg0);
			}
			catch(Exception e)
			{
				return LuaDLL.luaL_error(L, e.Message);
			}

			LuaDLL.lua_pushstring(L, o);
			return 1;
		}
		else if (count == 2 && ToLua.CheckTypes(L, 1, typeof(UILabel), typeof(UnityEngine.Vector3)))
		{
			UILabel obj = (UILabel)ToLua.ToObject(L, 1);
			UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
			string o = null;

			try
			{
				o = obj.GetWordAtPosition(arg0);
			}
			catch(Exception e)
			{
				return LuaDLL.luaL_error(L, e.Message);
			}

			LuaDLL.lua_pushstring(L, o);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: UILabel.GetWordAtPosition");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetWordAtCharacterIndex(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 2);
		UILabel obj = (UILabel)ToLua.CheckObject(L, 1, typeof(UILabel));
		int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
		string o = null;

		try
		{
			o = obj.GetWordAtCharacterIndex(arg0);
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		LuaDLL.lua_pushstring(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetUrlAtPosition(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 2 && ToLua.CheckTypes(L, 1, typeof(UILabel), typeof(UnityEngine.Vector2)))
		{
			UILabel obj = (UILabel)ToLua.ToObject(L, 1);
			UnityEngine.Vector2 arg0 = ToLua.ToVector2(L, 2);
			string o = null;

			try
			{
				o = obj.GetUrlAtPosition(arg0);
			}
			catch(Exception e)
			{
				return LuaDLL.luaL_error(L, e.Message);
			}

			LuaDLL.lua_pushstring(L, o);
			return 1;
		}
		else if (count == 2 && ToLua.CheckTypes(L, 1, typeof(UILabel), typeof(UnityEngine.Vector3)))
		{
			UILabel obj = (UILabel)ToLua.ToObject(L, 1);
			UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
			string o = null;

			try
			{
				o = obj.GetUrlAtPosition(arg0);
			}
			catch(Exception e)
			{
				return LuaDLL.luaL_error(L, e.Message);
			}

			LuaDLL.lua_pushstring(L, o);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: UILabel.GetUrlAtPosition");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetUrlAtCharacterIndex(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 2);
		UILabel obj = (UILabel)ToLua.CheckObject(L, 1, typeof(UILabel));
		int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
		string o = null;

		try
		{
			o = obj.GetUrlAtCharacterIndex(arg0);
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		LuaDLL.lua_pushstring(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetCharacterIndex(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 3);
		UILabel obj = (UILabel)ToLua.CheckObject(L, 1, typeof(UILabel));
		int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
		UnityEngine.KeyCode arg1 = (UnityEngine.KeyCode)ToLua.CheckObject(L, 3, typeof(UnityEngine.KeyCode));
		int o;

		try
		{
			o = obj.GetCharacterIndex(arg0, arg1);
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		LuaDLL.lua_pushinteger(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int PrintOverlay(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 7);
		UILabel obj = (UILabel)ToLua.CheckObject(L, 1, typeof(UILabel));
		int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
		int arg1 = (int)LuaDLL.luaL_checknumber(L, 3);
		UIGeometry arg2 = (UIGeometry)ToLua.CheckObject(L, 4, typeof(UIGeometry));
		UIGeometry arg3 = (UIGeometry)ToLua.CheckObject(L, 5, typeof(UIGeometry));
		UnityEngine.Color arg4 = ToLua.ToColor(L, 6);
		UnityEngine.Color arg5 = ToLua.ToColor(L, 7);

		try
		{
			obj.PrintOverlay(arg0, arg1, arg2, arg3, arg4, arg5);
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnFill(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 4);
		UILabel obj = (UILabel)ToLua.CheckObject(L, 1, typeof(UILabel));
		BetterList<UnityEngine.Vector3> arg0 = (BetterList<UnityEngine.Vector3>)ToLua.CheckObject(L, 2, typeof(BetterList<UnityEngine.Vector3>));
		BetterList<UnityEngine.Vector2> arg1 = (BetterList<UnityEngine.Vector2>)ToLua.CheckObject(L, 3, typeof(BetterList<UnityEngine.Vector2>));
		BetterList<UnityEngine.Color32> arg2 = (BetterList<UnityEngine.Color32>)ToLua.CheckObject(L, 4, typeof(BetterList<UnityEngine.Color32>));

		try
		{
			obj.OnFill(arg0, arg1, arg2);
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ApplyOffset(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 3);
		UILabel obj = (UILabel)ToLua.CheckObject(L, 1, typeof(UILabel));
		BetterList<UnityEngine.Vector3> arg0 = (BetterList<UnityEngine.Vector3>)ToLua.CheckObject(L, 2, typeof(BetterList<UnityEngine.Vector3>));
		int arg1 = (int)LuaDLL.luaL_checknumber(L, 3);
		UnityEngine.Vector2 o;

		try
		{
			o = obj.ApplyOffset(arg0, arg1);
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		ToLua.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ApplyShadow(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 8);
		UILabel obj = (UILabel)ToLua.CheckObject(L, 1, typeof(UILabel));
		BetterList<UnityEngine.Vector3> arg0 = (BetterList<UnityEngine.Vector3>)ToLua.CheckObject(L, 2, typeof(BetterList<UnityEngine.Vector3>));
		BetterList<UnityEngine.Vector2> arg1 = (BetterList<UnityEngine.Vector2>)ToLua.CheckObject(L, 3, typeof(BetterList<UnityEngine.Vector2>));
		BetterList<UnityEngine.Color32> arg2 = (BetterList<UnityEngine.Color32>)ToLua.CheckObject(L, 4, typeof(BetterList<UnityEngine.Color32>));
		int arg3 = (int)LuaDLL.luaL_checknumber(L, 5);
		int arg4 = (int)LuaDLL.luaL_checknumber(L, 6);
		float arg5 = (float)LuaDLL.luaL_checknumber(L, 7);
		float arg6 = (float)LuaDLL.luaL_checknumber(L, 8);

		try
		{
			obj.ApplyShadow(arg0, arg1, arg2, arg3, arg4, arg5, arg6);
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CalculateOffsetToFit(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 2);
		UILabel obj = (UILabel)ToLua.CheckObject(L, 1, typeof(UILabel));
		string arg0 = ToLua.CheckString(L, 2);
		int o;

		try
		{
			o = obj.CalculateOffsetToFit(arg0);
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		LuaDLL.lua_pushinteger(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetCurrentProgress(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 1);
		UILabel obj = (UILabel)ToLua.CheckObject(L, 1, typeof(UILabel));

		try
		{
			obj.SetCurrentProgress();
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetCurrentPercent(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 1);
		UILabel obj = (UILabel)ToLua.CheckObject(L, 1, typeof(UILabel));

		try
		{
			obj.SetCurrentPercent();
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetCurrentSelection(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 1);
		UILabel obj = (UILabel)ToLua.CheckObject(L, 1, typeof(UILabel));

		try
		{
			obj.SetCurrentSelection();
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Wrap(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 3 && ToLua.CheckTypes(L, 1, typeof(UILabel), typeof(string), typeof(LuaInterface.LuaOut<string>)))
		{
			UILabel obj = (UILabel)ToLua.ToObject(L, 1);
			string arg0 = ToLua.ToString(L, 2);
			string arg1 = null;
			bool o;

			try
			{
				o = obj.Wrap(arg0, out arg1);
			}
			catch(Exception e)
			{
				return LuaDLL.luaL_error(L, e.Message);
			}

			LuaDLL.lua_pushboolean(L, o);
			LuaDLL.lua_pushstring(L, arg1);
			return 2;
		}
		else if (count == 4 && ToLua.CheckTypes(L, 1, typeof(UILabel), typeof(string), typeof(LuaInterface.LuaOut<string>), typeof(int)))
		{
			UILabel obj = (UILabel)ToLua.ToObject(L, 1);
			string arg0 = ToLua.ToString(L, 2);
			string arg1 = null;
			int arg2 = (int)LuaDLL.lua_tonumber(L, 4);
			bool o;

			try
			{
				o = obj.Wrap(arg0, out arg1, arg2);
			}
			catch(Exception e)
			{
				return LuaDLL.luaL_error(L, e.Message);
			}

			LuaDLL.lua_pushboolean(L, o);
			LuaDLL.lua_pushstring(L, arg1);
			return 2;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: UILabel.Wrap");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UpdateNGUIText(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 1);
		UILabel obj = (UILabel)ToLua.CheckObject(L, 1, typeof(UILabel));

		try
		{
			obj.UpdateNGUIText();
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
	static int get_keepCrispWhenShrunk(IntPtr L)
	{
		UILabel obj = (UILabel)ToLua.ToObject(L, 1);
		UILabel.Crispness ret;

		try
		{
			ret = obj.keepCrispWhenShrunk;
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, obj == null ? "attempt to index keepCrispWhenShrunk on a nil value" : e.Message);
		}

		ToLua.Push(L, ret);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_isAnchoredHorizontally(IntPtr L)
	{
		UILabel obj = (UILabel)ToLua.ToObject(L, 1);
		bool ret;

		try
		{
			ret = obj.isAnchoredHorizontally;
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, obj == null ? "attempt to index isAnchoredHorizontally on a nil value" : e.Message);
		}

		LuaDLL.lua_pushboolean(L, ret);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_isAnchoredVertically(IntPtr L)
	{
		UILabel obj = (UILabel)ToLua.ToObject(L, 1);
		bool ret;

		try
		{
			ret = obj.isAnchoredVertically;
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, obj == null ? "attempt to index isAnchoredVertically on a nil value" : e.Message);
		}

		LuaDLL.lua_pushboolean(L, ret);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_material(IntPtr L)
	{
		UILabel obj = (UILabel)ToLua.ToObject(L, 1);
		UnityEngine.Material ret = null;

		try
		{
			ret = obj.material;
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, obj == null ? "attempt to index material on a nil value" : e.Message);
		}

		ToLua.Push(L, ret);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_bitmapFont(IntPtr L)
	{
		UILabel obj = (UILabel)ToLua.ToObject(L, 1);
		UIFont ret = null;

		try
		{
			ret = obj.bitmapFont;
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, obj == null ? "attempt to index bitmapFont on a nil value" : e.Message);
		}

		ToLua.Push(L, ret);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_trueTypeFont(IntPtr L)
	{
		UILabel obj = (UILabel)ToLua.ToObject(L, 1);
		UnityEngine.Font ret = null;

		try
		{
			ret = obj.trueTypeFont;
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, obj == null ? "attempt to index trueTypeFont on a nil value" : e.Message);
		}

		ToLua.Push(L, ret);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_ambigiousFont(IntPtr L)
	{
		UILabel obj = (UILabel)ToLua.ToObject(L, 1);
		UnityEngine.Object ret = null;

		try
		{
			ret = obj.ambigiousFont;
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, obj == null ? "attempt to index ambigiousFont on a nil value" : e.Message);
		}

		ToLua.Push(L, ret);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_text(IntPtr L)
	{
		UILabel obj = (UILabel)ToLua.ToObject(L, 1);
		string ret = null;

		try
		{
			ret = obj.text;
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, obj == null ? "attempt to index text on a nil value" : e.Message);
		}

		LuaDLL.lua_pushstring(L, ret);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_defaultFontSize(IntPtr L)
	{
		UILabel obj = (UILabel)ToLua.ToObject(L, 1);
		int ret;

		try
		{
			ret = obj.defaultFontSize;
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, obj == null ? "attempt to index defaultFontSize on a nil value" : e.Message);
		}

		LuaDLL.lua_pushinteger(L, ret);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_fontSize(IntPtr L)
	{
		UILabel obj = (UILabel)ToLua.ToObject(L, 1);
		int ret;

		try
		{
			ret = obj.fontSize;
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, obj == null ? "attempt to index fontSize on a nil value" : e.Message);
		}

		LuaDLL.lua_pushinteger(L, ret);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_fontStyle(IntPtr L)
	{
		UILabel obj = (UILabel)ToLua.ToObject(L, 1);
		UnityEngine.FontStyle ret;

		try
		{
			ret = obj.fontStyle;
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, obj == null ? "attempt to index fontStyle on a nil value" : e.Message);
		}

		ToLua.Push(L, ret);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_alignment(IntPtr L)
	{
		UILabel obj = (UILabel)ToLua.ToObject(L, 1);
		NGUIText.Alignment ret;

		try
		{
			ret = obj.alignment;
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, obj == null ? "attempt to index alignment on a nil value" : e.Message);
		}

		ToLua.Push(L, ret);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_applyGradient(IntPtr L)
	{
		UILabel obj = (UILabel)ToLua.ToObject(L, 1);
		bool ret;

		try
		{
			ret = obj.applyGradient;
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, obj == null ? "attempt to index applyGradient on a nil value" : e.Message);
		}

		LuaDLL.lua_pushboolean(L, ret);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_gradientTop(IntPtr L)
	{
		UILabel obj = (UILabel)ToLua.ToObject(L, 1);
		UnityEngine.Color ret;

		try
		{
			ret = obj.gradientTop;
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, obj == null ? "attempt to index gradientTop on a nil value" : e.Message);
		}

		ToLua.Push(L, ret);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_gradientBottom(IntPtr L)
	{
		UILabel obj = (UILabel)ToLua.ToObject(L, 1);
		UnityEngine.Color ret;

		try
		{
			ret = obj.gradientBottom;
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, obj == null ? "attempt to index gradientBottom on a nil value" : e.Message);
		}

		ToLua.Push(L, ret);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_spacingX(IntPtr L)
	{
		UILabel obj = (UILabel)ToLua.ToObject(L, 1);
		int ret;

		try
		{
			ret = obj.spacingX;
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, obj == null ? "attempt to index spacingX on a nil value" : e.Message);
		}

		LuaDLL.lua_pushinteger(L, ret);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_spacingY(IntPtr L)
	{
		UILabel obj = (UILabel)ToLua.ToObject(L, 1);
		int ret;

		try
		{
			ret = obj.spacingY;
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, obj == null ? "attempt to index spacingY on a nil value" : e.Message);
		}

		LuaDLL.lua_pushinteger(L, ret);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_useFloatSpacing(IntPtr L)
	{
		UILabel obj = (UILabel)ToLua.ToObject(L, 1);
		bool ret;

		try
		{
			ret = obj.useFloatSpacing;
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, obj == null ? "attempt to index useFloatSpacing on a nil value" : e.Message);
		}

		LuaDLL.lua_pushboolean(L, ret);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_floatSpacingX(IntPtr L)
	{
		UILabel obj = (UILabel)ToLua.ToObject(L, 1);
		float ret;

		try
		{
			ret = obj.floatSpacingX;
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, obj == null ? "attempt to index floatSpacingX on a nil value" : e.Message);
		}

		LuaDLL.lua_pushnumber(L, ret);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_floatSpacingY(IntPtr L)
	{
		UILabel obj = (UILabel)ToLua.ToObject(L, 1);
		float ret;

		try
		{
			ret = obj.floatSpacingY;
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, obj == null ? "attempt to index floatSpacingY on a nil value" : e.Message);
		}

		LuaDLL.lua_pushnumber(L, ret);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_effectiveSpacingY(IntPtr L)
	{
		UILabel obj = (UILabel)ToLua.ToObject(L, 1);
		float ret;

		try
		{
			ret = obj.effectiveSpacingY;
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, obj == null ? "attempt to index effectiveSpacingY on a nil value" : e.Message);
		}

		LuaDLL.lua_pushnumber(L, ret);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_effectiveSpacingX(IntPtr L)
	{
		UILabel obj = (UILabel)ToLua.ToObject(L, 1);
		float ret;

		try
		{
			ret = obj.effectiveSpacingX;
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, obj == null ? "attempt to index effectiveSpacingX on a nil value" : e.Message);
		}

		LuaDLL.lua_pushnumber(L, ret);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_supportEncoding(IntPtr L)
	{
		UILabel obj = (UILabel)ToLua.ToObject(L, 1);
		bool ret;

		try
		{
			ret = obj.supportEncoding;
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, obj == null ? "attempt to index supportEncoding on a nil value" : e.Message);
		}

		LuaDLL.lua_pushboolean(L, ret);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_symbolStyle(IntPtr L)
	{
		UILabel obj = (UILabel)ToLua.ToObject(L, 1);
		NGUIText.SymbolStyle ret;

		try
		{
			ret = obj.symbolStyle;
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, obj == null ? "attempt to index symbolStyle on a nil value" : e.Message);
		}

		ToLua.Push(L, ret);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_overflowMethod(IntPtr L)
	{
		UILabel obj = (UILabel)ToLua.ToObject(L, 1);
		UILabel.Overflow ret;

		try
		{
			ret = obj.overflowMethod;
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, obj == null ? "attempt to index overflowMethod on a nil value" : e.Message);
		}

		ToLua.Push(L, ret);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_multiLine(IntPtr L)
	{
		UILabel obj = (UILabel)ToLua.ToObject(L, 1);
		bool ret;

		try
		{
			ret = obj.multiLine;
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, obj == null ? "attempt to index multiLine on a nil value" : e.Message);
		}

		LuaDLL.lua_pushboolean(L, ret);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_localCorners(IntPtr L)
	{
		UILabel obj = (UILabel)ToLua.ToObject(L, 1);
		UnityEngine.Vector3[] ret = null;

		try
		{
			ret = obj.localCorners;
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, obj == null ? "attempt to index localCorners on a nil value" : e.Message);
		}

		ToLua.Push(L, ret);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_worldCorners(IntPtr L)
	{
		UILabel obj = (UILabel)ToLua.ToObject(L, 1);
		UnityEngine.Vector3[] ret = null;

		try
		{
			ret = obj.worldCorners;
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, obj == null ? "attempt to index worldCorners on a nil value" : e.Message);
		}

		ToLua.Push(L, ret);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_drawingDimensions(IntPtr L)
	{
		UILabel obj = (UILabel)ToLua.ToObject(L, 1);
		UnityEngine.Vector4 ret;

		try
		{
			ret = obj.drawingDimensions;
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, obj == null ? "attempt to index drawingDimensions on a nil value" : e.Message);
		}

		ToLua.Push(L, ret);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_maxLineCount(IntPtr L)
	{
		UILabel obj = (UILabel)ToLua.ToObject(L, 1);
		int ret;

		try
		{
			ret = obj.maxLineCount;
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, obj == null ? "attempt to index maxLineCount on a nil value" : e.Message);
		}

		LuaDLL.lua_pushinteger(L, ret);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_effectStyle(IntPtr L)
	{
		UILabel obj = (UILabel)ToLua.ToObject(L, 1);
		UILabel.Effect ret;

		try
		{
			ret = obj.effectStyle;
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, obj == null ? "attempt to index effectStyle on a nil value" : e.Message);
		}

		ToLua.Push(L, ret);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_effectColor(IntPtr L)
	{
		UILabel obj = (UILabel)ToLua.ToObject(L, 1);
		UnityEngine.Color ret;

		try
		{
			ret = obj.effectColor;
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, obj == null ? "attempt to index effectColor on a nil value" : e.Message);
		}

		ToLua.Push(L, ret);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_effectDistance(IntPtr L)
	{
		UILabel obj = (UILabel)ToLua.ToObject(L, 1);
		UnityEngine.Vector2 ret;

		try
		{
			ret = obj.effectDistance;
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, obj == null ? "attempt to index effectDistance on a nil value" : e.Message);
		}

		ToLua.Push(L, ret);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_processedText(IntPtr L)
	{
		UILabel obj = (UILabel)ToLua.ToObject(L, 1);
		string ret = null;

		try
		{
			ret = obj.processedText;
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, obj == null ? "attempt to index processedText on a nil value" : e.Message);
		}

		LuaDLL.lua_pushstring(L, ret);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_printedSize(IntPtr L)
	{
		UILabel obj = (UILabel)ToLua.ToObject(L, 1);
		UnityEngine.Vector2 ret;

		try
		{
			ret = obj.printedSize;
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, obj == null ? "attempt to index printedSize on a nil value" : e.Message);
		}

		ToLua.Push(L, ret);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_localSize(IntPtr L)
	{
		UILabel obj = (UILabel)ToLua.ToObject(L, 1);
		UnityEngine.Vector2 ret;

		try
		{
			ret = obj.localSize;
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, obj == null ? "attempt to index localSize on a nil value" : e.Message);
		}

		ToLua.Push(L, ret);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_keepCrispWhenShrunk(IntPtr L)
	{
		UILabel obj = (UILabel)ToLua.ToObject(L, 1);
		UILabel.Crispness arg0 = (UILabel.Crispness)ToLua.CheckObject(L, 2, typeof(UILabel.Crispness));

		try
		{
			obj.keepCrispWhenShrunk = arg0;
		}
		catch(Exception e)
		{
			if (obj == null)
			{
				LuaDLL.luaL_error(L, "attempt to index keepCrispWhenShrunk on a nil value");
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
	static int set_material(IntPtr L)
	{
		UILabel obj = (UILabel)ToLua.ToObject(L, 1);
		UnityEngine.Material arg0 = (UnityEngine.Material)ToLua.CheckUnityObject(L, 2, typeof(UnityEngine.Material));

		try
		{
			obj.material = arg0;
		}
		catch(Exception e)
		{
			if (obj == null)
			{
				LuaDLL.luaL_error(L, "attempt to index material on a nil value");
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
	static int set_bitmapFont(IntPtr L)
	{
		UILabel obj = (UILabel)ToLua.ToObject(L, 1);
		UIFont arg0 = (UIFont)ToLua.CheckUnityObject(L, 2, typeof(UIFont));

		try
		{
			obj.bitmapFont = arg0;
		}
		catch(Exception e)
		{
			if (obj == null)
			{
				LuaDLL.luaL_error(L, "attempt to index bitmapFont on a nil value");
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
	static int set_trueTypeFont(IntPtr L)
	{
		UILabel obj = (UILabel)ToLua.ToObject(L, 1);
		UnityEngine.Font arg0 = (UnityEngine.Font)ToLua.CheckUnityObject(L, 2, typeof(UnityEngine.Font));

		try
		{
			obj.trueTypeFont = arg0;
		}
		catch(Exception e)
		{
			if (obj == null)
			{
				LuaDLL.luaL_error(L, "attempt to index trueTypeFont on a nil value");
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
	static int set_ambigiousFont(IntPtr L)
	{
		UILabel obj = (UILabel)ToLua.ToObject(L, 1);
		UnityEngine.Object arg0 = (UnityEngine.Object)ToLua.CheckUnityObject(L, 2, typeof(UnityEngine.Object));

		try
		{
			obj.ambigiousFont = arg0;
		}
		catch(Exception e)
		{
			if (obj == null)
			{
				LuaDLL.luaL_error(L, "attempt to index ambigiousFont on a nil value");
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
	static int set_text(IntPtr L)
	{
		UILabel obj = (UILabel)ToLua.ToObject(L, 1);
		string arg0 = ToLua.CheckString(L, 2);

		try
		{
			obj.text = arg0;
		}
		catch(Exception e)
		{
			if (obj == null)
			{
				LuaDLL.luaL_error(L, "attempt to index text on a nil value");
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
	static int set_fontSize(IntPtr L)
	{
		UILabel obj = (UILabel)ToLua.ToObject(L, 1);
		int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);

		try
		{
			obj.fontSize = arg0;
		}
		catch(Exception e)
		{
			if (obj == null)
			{
				LuaDLL.luaL_error(L, "attempt to index fontSize on a nil value");
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
	static int set_fontStyle(IntPtr L)
	{
		UILabel obj = (UILabel)ToLua.ToObject(L, 1);
		UnityEngine.FontStyle arg0 = (UnityEngine.FontStyle)ToLua.CheckObject(L, 2, typeof(UnityEngine.FontStyle));

		try
		{
			obj.fontStyle = arg0;
		}
		catch(Exception e)
		{
			if (obj == null)
			{
				LuaDLL.luaL_error(L, "attempt to index fontStyle on a nil value");
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
	static int set_alignment(IntPtr L)
	{
		UILabel obj = (UILabel)ToLua.ToObject(L, 1);
		NGUIText.Alignment arg0 = (NGUIText.Alignment)ToLua.CheckObject(L, 2, typeof(NGUIText.Alignment));

		try
		{
			obj.alignment = arg0;
		}
		catch(Exception e)
		{
			if (obj == null)
			{
				LuaDLL.luaL_error(L, "attempt to index alignment on a nil value");
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
	static int set_applyGradient(IntPtr L)
	{
		UILabel obj = (UILabel)ToLua.ToObject(L, 1);
		bool arg0 = LuaDLL.luaL_checkboolean(L, 2);

		try
		{
			obj.applyGradient = arg0;
		}
		catch(Exception e)
		{
			if (obj == null)
			{
				LuaDLL.luaL_error(L, "attempt to index applyGradient on a nil value");
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
	static int set_gradientTop(IntPtr L)
	{
		UILabel obj = (UILabel)ToLua.ToObject(L, 1);
		UnityEngine.Color arg0 = ToLua.ToColor(L, 2);

		try
		{
			obj.gradientTop = arg0;
		}
		catch(Exception e)
		{
			if (obj == null)
			{
				LuaDLL.luaL_error(L, "attempt to index gradientTop on a nil value");
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
	static int set_gradientBottom(IntPtr L)
	{
		UILabel obj = (UILabel)ToLua.ToObject(L, 1);
		UnityEngine.Color arg0 = ToLua.ToColor(L, 2);

		try
		{
			obj.gradientBottom = arg0;
		}
		catch(Exception e)
		{
			if (obj == null)
			{
				LuaDLL.luaL_error(L, "attempt to index gradientBottom on a nil value");
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
	static int set_spacingX(IntPtr L)
	{
		UILabel obj = (UILabel)ToLua.ToObject(L, 1);
		int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);

		try
		{
			obj.spacingX = arg0;
		}
		catch(Exception e)
		{
			if (obj == null)
			{
				LuaDLL.luaL_error(L, "attempt to index spacingX on a nil value");
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
	static int set_spacingY(IntPtr L)
	{
		UILabel obj = (UILabel)ToLua.ToObject(L, 1);
		int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);

		try
		{
			obj.spacingY = arg0;
		}
		catch(Exception e)
		{
			if (obj == null)
			{
				LuaDLL.luaL_error(L, "attempt to index spacingY on a nil value");
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
	static int set_useFloatSpacing(IntPtr L)
	{
		UILabel obj = (UILabel)ToLua.ToObject(L, 1);
		bool arg0 = LuaDLL.luaL_checkboolean(L, 2);

		try
		{
			obj.useFloatSpacing = arg0;
		}
		catch(Exception e)
		{
			if (obj == null)
			{
				LuaDLL.luaL_error(L, "attempt to index useFloatSpacing on a nil value");
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
	static int set_floatSpacingX(IntPtr L)
	{
		UILabel obj = (UILabel)ToLua.ToObject(L, 1);
		float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);

		try
		{
			obj.floatSpacingX = arg0;
		}
		catch(Exception e)
		{
			if (obj == null)
			{
				LuaDLL.luaL_error(L, "attempt to index floatSpacingX on a nil value");
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
	static int set_floatSpacingY(IntPtr L)
	{
		UILabel obj = (UILabel)ToLua.ToObject(L, 1);
		float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);

		try
		{
			obj.floatSpacingY = arg0;
		}
		catch(Exception e)
		{
			if (obj == null)
			{
				LuaDLL.luaL_error(L, "attempt to index floatSpacingY on a nil value");
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
	static int set_supportEncoding(IntPtr L)
	{
		UILabel obj = (UILabel)ToLua.ToObject(L, 1);
		bool arg0 = LuaDLL.luaL_checkboolean(L, 2);

		try
		{
			obj.supportEncoding = arg0;
		}
		catch(Exception e)
		{
			if (obj == null)
			{
				LuaDLL.luaL_error(L, "attempt to index supportEncoding on a nil value");
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
	static int set_symbolStyle(IntPtr L)
	{
		UILabel obj = (UILabel)ToLua.ToObject(L, 1);
		NGUIText.SymbolStyle arg0 = (NGUIText.SymbolStyle)ToLua.CheckObject(L, 2, typeof(NGUIText.SymbolStyle));

		try
		{
			obj.symbolStyle = arg0;
		}
		catch(Exception e)
		{
			if (obj == null)
			{
				LuaDLL.luaL_error(L, "attempt to index symbolStyle on a nil value");
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
	static int set_overflowMethod(IntPtr L)
	{
		UILabel obj = (UILabel)ToLua.ToObject(L, 1);
		UILabel.Overflow arg0 = (UILabel.Overflow)ToLua.CheckObject(L, 2, typeof(UILabel.Overflow));

		try
		{
			obj.overflowMethod = arg0;
		}
		catch(Exception e)
		{
			if (obj == null)
			{
				LuaDLL.luaL_error(L, "attempt to index overflowMethod on a nil value");
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
	static int set_multiLine(IntPtr L)
	{
		UILabel obj = (UILabel)ToLua.ToObject(L, 1);
		bool arg0 = LuaDLL.luaL_checkboolean(L, 2);

		try
		{
			obj.multiLine = arg0;
		}
		catch(Exception e)
		{
			if (obj == null)
			{
				LuaDLL.luaL_error(L, "attempt to index multiLine on a nil value");
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
	static int set_maxLineCount(IntPtr L)
	{
		UILabel obj = (UILabel)ToLua.ToObject(L, 1);
		int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);

		try
		{
			obj.maxLineCount = arg0;
		}
		catch(Exception e)
		{
			if (obj == null)
			{
				LuaDLL.luaL_error(L, "attempt to index maxLineCount on a nil value");
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
	static int set_effectStyle(IntPtr L)
	{
		UILabel obj = (UILabel)ToLua.ToObject(L, 1);
		UILabel.Effect arg0 = (UILabel.Effect)ToLua.CheckObject(L, 2, typeof(UILabel.Effect));

		try
		{
			obj.effectStyle = arg0;
		}
		catch(Exception e)
		{
			if (obj == null)
			{
				LuaDLL.luaL_error(L, "attempt to index effectStyle on a nil value");
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
	static int set_effectColor(IntPtr L)
	{
		UILabel obj = (UILabel)ToLua.ToObject(L, 1);
		UnityEngine.Color arg0 = ToLua.ToColor(L, 2);

		try
		{
			obj.effectColor = arg0;
		}
		catch(Exception e)
		{
			if (obj == null)
			{
				LuaDLL.luaL_error(L, "attempt to index effectColor on a nil value");
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
	static int set_effectDistance(IntPtr L)
	{
		UILabel obj = (UILabel)ToLua.ToObject(L, 1);
		UnityEngine.Vector2 arg0 = ToLua.ToVector2(L, 2);

		try
		{
			obj.effectDistance = arg0;
		}
		catch(Exception e)
		{
			if (obj == null)
			{
				LuaDLL.luaL_error(L, "attempt to index effectDistance on a nil value");
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
		ToLua.PushOut<UILabel>(L, new LuaOut<UILabel>());
		return 1;
	}
}

