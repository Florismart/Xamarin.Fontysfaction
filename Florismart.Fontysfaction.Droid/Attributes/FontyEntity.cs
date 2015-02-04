using System;

namespace Florismart.Fontisfaction.Droid.Attributes
{
	[AttributeUsage (AttributeTargets.Class, Inherited = true)]
	public class FontyEntity: Attribute
	{
		public string Path;

		public FontyEntity ()
		{
		}
	}
}

