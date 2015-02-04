using System;
using Android.Widget;
using Android.Content;
using Android.Util;
using Android.Content.Res;
using Florismart.Fontisfaction.Droid.Core;
using Florismart.Fontisfaction.Droid.Config;
using Florismart.Fontysfaction.Droid;

namespace Florismart.Fontisfaction.Droid.View
{
	/// <summary>
	/// Fonty button.
	/// </summary>
	public class FontyEditText: EditText
	{

		protected readonly static string TAG = "FontyEditText";

		public FontyEditText (Context context) : base (context)
		{
		}

		public FontyEditText (Context context, IAttributeSet attrs) : base (context, attrs)
		{
			initAttributes (context, attrs);
		}

		public FontyEditText (Context context, IAttributeSet attrs, int defStyle) : base (context, attrs, defStyle)
		{
		}

		protected void initAttributes (Context context, IAttributeSet attrs)
		{
			if (attrs != null) {
				TypedArray a = context.ObtainStyledAttributes (attrs, Resource.Styleable.Fontable);
				int fontTypo = a.GetInteger (Resource.Styleable.Fontable_font, 0);
				setCustomFont (fontTypo);
				a.Recycle ();
			}
		}

		private bool setCustomFont (int fontTypo)
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

