using System;
using Android.Graphics;
using Android.Content;
using Android.Util;
using Florismart.Fontisfaction.Droid.Config;
using Florismart.Fontisfaction.Droid.Config.Loader;

namespace Florismart.Fontisfaction.Droid.Core
{
	public class FontyLoader
	{
		private static string TAG = "FontyLoader";
		private static FontyCache fontCache = new FontyCache ();

		private FontyConfiguration configuration;
		private static FontyLoader instance = null;

		public static FontyLoader GetInstance ()
		{
			if (instance == null) {
				instance = new FontyLoader ();
			}
			return instance;
		}

		public FontyLoader Init (FontyConfiguration configuration)
		{
			this.configuration = configuration;
			return this;
		}

		public Typeface GetFont (Context context, FontyTypo font)
		{
			lock (fontCache) {

				if (fontCache.ContainsKey (font)) {
					return fontCache [font];
				}

				Typeface typeface;
				if (configuration.SourceTypo == FontySourceTypo.assets)
					typeface = AssetsLoader.Get (context, configuration, font);
				else
					typeface = Typeface.Default;

				fontCache.Add (font, typeface);
				return typeface;
			}
		}

	}

}

