using System;
using Florismart.Fontisfaction.Droid.Attributes;
using Florismart.Fontisfaction.Droid.Config;

namespace Florismart.Fontysfaction.Droid.Sample
{
	[FontyEntity]
	[FontyPath (Value = "fonts")]
	public class MyFontyEntity
	{
		[FontyIdentifier (Value = FontyTypo.regular)]
		[FontyName (Value = "Roboto-Regular")]
		[FontyPath (Value = "roboto")]
		public String regular;

		[FontyIdentifier (Value = FontyTypo.bold)]
		[FontyName (Value = "Roboto-Bold")]
		[FontyPath (Value = "roboto")]
		public String bold;

		[FontyIdentifier (Value = FontyTypo.light)]
		[FontyName (Value = "Roboto-Thin")]
		[FontyPath (Value = "roboto")]
		public String light;

		[FontyIdentifier (Value = FontyTypo.regular_italic)]
		[FontyName (Value = "RobotoSlab-Regular")]
		[FontyPath (Value = "roboto")]	
		public String regular_italic;

		[FontyIdentifier (Value = FontyTypo.bold_italic)]
		[FontyName (Value = "Roboto-BoldCondensed")]
		[FontyPath (Value = "roboto")]
		public String bold_italic;

		[FontyIdentifier (Value = FontyTypo.light_italic)]
		[FontyName (Value = "RobotoSlab-Regular")]
		[FontyPath (Value = "roboto")]
		public String light_italic;
	}


}

