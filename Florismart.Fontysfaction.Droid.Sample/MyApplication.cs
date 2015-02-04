using System;
using Android.App;
using Android.Runtime;
using Android.Util;
using Florismart.Fontisfaction.Droid.Config;
using Florismart.Fontisfaction.Droid.Core;

namespace Florismart.Fontysfaction.Droid.Sample
{
	[Application]
	class MyApplication: Application
	{

		public MyApplication (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		public override void OnCreate ()
		{
			base.OnCreate ();

			FontyConfiguration configuration = new FontyConfiguration () {
				Extension = ".ttf",
				FontEntityClazz = typeof(MyFontyEntity),
				SourceTypo = FontySourceTypo.assets
			};

			FontyLoader.GetInstance ().Init (configuration);
		}


	}
}

