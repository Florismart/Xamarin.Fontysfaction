using System;
using Android.Graphics;
using Android.Content;
using System.Reflection;
using System.Collections.Generic;
using Android.Util;
using Florismart.Fontisfaction.Droid.Attributes;

namespace Florismart.Fontisfaction.Droid.Config.Loader
{
	public class AssetsLoader
	{
		private static string TAG = "AssetsLoader";

		public static Typeface Get (Context context, FontyConfiguration configuration, FontyTypo font)
		{ 
			try {
				List<string> pathStack = new List<string> ();
				string resourceFullPath;
				pathStack.Add (configuration.Path);

				if (configuration.FontEntityClazz.IsDefined (typeof(FontyPath), true)) {
					Log.Verbose (TAG, "FontPath in root entity: compose url");

					FontyPath path = configuration.FontEntityClazz.GetCustomAttribute<FontyPath> (true);
					Log.Verbose (TAG, "entity annotated with FontPath annotation: " + path.Value);
					pathStack.Add (path.Value);

				}

				foreach (FieldInfo field in configuration.FontEntityClazz.GetFields()) {

					if (field.IsDefined (typeof(FontyIdentifier), true)) {
						Log.Verbose (TAG, "field: " + field.Name + " annotated with FontIdentifier");
					}

					if (field.GetCustomAttribute<FontyIdentifier> (true).Value == font) {
						if (field.IsDefined (typeof(FontyPath), true)) {
							FontyPath path = field.GetCustomAttribute<FontyPath> (true);
							pathStack.Add (path.Value);
						}

						if (field.IsDefined (typeof(FontyName), true)) {
							FontyName name = field.GetCustomAttribute<FontyName> (true);
							resourceFullPath = joinPaths (pathStack) + name.Value;
							Log.Verbose (TAG, "field: " + field.Name + " annotated with FontName with value: " + name.Value);
						} else {
							Log.Verbose (TAG, "field: " + field.Name + " not annotated with FontName, use his name");
							resourceFullPath = joinPaths (pathStack) + field.Name;
						}

						resourceFullPath += configuration.Extension;
						Log.Debug (TAG, resourceFullPath);
						return Typeface.CreateFromAsset (context.Assets, resourceFullPath);
					}

				}
			} catch (Exception e) {
				Log.Error (TAG, e.StackTrace);
				Log.Error (TAG, "can't load " + font.ToString () + " return default one");
			}
			return Typeface.Default;
		}

		protected static String joinPaths (List<string> paths)
		{
			string sPath = string.Empty;
			foreach (string path in paths) {
				if (!string.IsNullOrEmpty (path)) {
					if (string.Empty.Equals (sPath))
						sPath = path + "/";
					else
						sPath += path + "/";
				}
			}
			return sPath;
		}

		protected static string enrichResourcePath (string basePath, string resource)
		{
			Log.Verbose (TAG, "enrichResourcePath with params: " + basePath + " " + resource);
			if (string.IsNullOrEmpty (resource))
				return basePath;
			return basePath + "/" + resource;
		}
	}
}

