using System;
using Florismart.Fontisfaction.Droid.Attributes;

namespace Florismart.Fontisfaction.Droid.Config
{
	[FontyEntity]
	[FontyPath (Value = "fonts")]
	public class FontyBaseEntity
	{
		[FontyIdentifier (Value = FontyTypo.regular)]
		[FontyName (Value = "regular")]
		public String regular;

		[FontyIdentifier (Value = FontyTypo.bold)]
		[FontyName (Value = "bold")]
		public String bold;

		[FontyIdentifier (Value = FontyTypo.light)]
		[FontyName (Value = "light")]
		public String light;

		[FontyIdentifier (Value = FontyTypo.regular_italic)]
		[FontyName (Value = "regular_italic")]
		public String regular_italic;

		[FontyIdentifier (Value = FontyTypo.bold_italic)]
		[FontyName (Value = "bold_italic")]
		public String bold_italic;

		[FontyIdentifier (Value = FontyTypo.light_italic)]
		[FontyName (Value = "light_italic")]
		public String light_italic;
	}


}

