using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace Florismart.Fontysfaction.Droid.Sample
{
	[Activity (Label = "Fontysfaction", MainLauncher = true, Icon = "@drawable/icon")]
	public class MyActivity : Activity
	{

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			SetContentView (Resource.Layout.Main);
		}
	}
}


