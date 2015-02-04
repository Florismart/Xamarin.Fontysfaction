using System;

namespace Florismart.Fontisfaction.Droid.Attributes
{
	[AttributeUsage (AttributeTargets.Field | AttributeTargets.Class, Inherited = true)]
	public class FontyPath: Attribute
	{
		public string Value;

		public FontyPath ()
		{
		}
	}
}

