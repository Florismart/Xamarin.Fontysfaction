using System;
using Android.Widget;
using Android.Content;
using Android.Util;
using Android.Content.Res;
using Florismart.Fontisfaction.Droid.Config;
using Florismart.Fontisfaction.Droid.Core;
using Florismart.Fontysfaction.Droid;
using Android.Runtime;

namespace Florismart.Fontisfaction.Droid.View
{
	/// <summary>
	/// Fonty button.
	/// </summary>
	public class FontyButton: Button
	{

		protected readonly static string TAG = "FontyButton";

		public FontyButton (IntPtr javaReference, JniHandleOwnership transfere) : base (javaReference, transfere)
		{
		} 

		public FontyButton (Context context) : base (context)
		{
		}

		public FontyButton (Context context, IAttributeSet attrs) : base (context, attrs)
		{
			initAttributes (context, attrs);
		}

		public FontyButton (Context context, IAttributeSet attrs, int defStyle) : base (context, attrs, defStyle)
		{
		}

		protected virtual void initAttributes (Context context, IAttributeSet attrs)
		{
			if (attrs != null) {
				TypedArray a = context.ObtainStyledAttributes (attrs, Resource.Styleable.Fontable);
				int fontTypo = a.GetInteger (Resource.Styleable.Fontable_font, 0);
				setCustomFont (fontTypo);
				a.Recycle ();
			}
		}

		protected virtual bool setCustomFont (int fontTypo)
		{
			FontyTypo font = (FontyTypo)fontTypo;
			try {
				Typeface = FontyLoader.GetInstance ().GetFont (Context, font);
			} catch (Exception exception) {
				Log.Error (TAG, exception.StackTrace);
				Log.Error (TAG, "can't load typeface: " + font);
			}
			return true;
		}
	}
}

