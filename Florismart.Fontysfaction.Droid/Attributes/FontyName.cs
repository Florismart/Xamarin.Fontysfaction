using System;

namespace Florismart.Fontisfaction.Droid.Attributes
{
	[AttributeUsage (AttributeTargets.Field, Inherited = true)]
	public class FontyName: Attribute
	{
		public string Value;

		public FontyName ()
		{
		}
	}
}

