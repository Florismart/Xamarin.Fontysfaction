using System;

namespace Florismart.Fontisfaction.Droid.Config
{
	public class FontyConfiguration
	{
		protected string _path;
		protected string _extension;
		protected FontySourceTypo _sourceTypo;
		protected Type _fontEntityClazz;

		public string Path { 
			get { 
				return _path == null ? string.Empty : _path;
			}
			set {
				_path = value;
			}
		}

		public string Extension { 
			get {
				return _extension == null ? ".ttf" : _extension;
			} 
			set { 
				_extension = value;
			}
		}

		public FontySourceTypo SourceTypo { 
			get {
				return _sourceTypo;
			} 
			set { 
				_sourceTypo = value;
			}
		}

		public Type FontEntityClazz { 
			get { 
				return _fontEntityClazz;
			} 
			set { 
				_fontEntityClazz = value;
			}
		}
	}
}

