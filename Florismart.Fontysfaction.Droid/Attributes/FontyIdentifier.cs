using System;
using Florismart.Fontisfaction.Droid.Config;

namespace Florismart.Fontisfaction.Droid.Attributes
{
	[AttributeUsage (AttributeTargets.Field, Inherited = true)]
	public class FontyIdentifier: Attribute
	{
		public FontyTypo Value;

		public FontyIdentifier ()
		{
		}
	}
}

