using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Location.B {

	[Register ("com/baidu/location/b/f")]
	public abstract class F {

		internal F ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location.b']/interface[@name='f']/field[@name='bg']"
		[Register ("bg")]
		public const int Bg = (int) 6;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location.b']/interface[@name='f']/field[@name='bh']"
		[Register ("bh")]
		public const string Bh = (string) "6.0.5";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location.b']/interface[@name='f']/field[@name='bi']"
		[Register ("bi")]
		public const float Bi = (float) 6.050000;

		// The following are fields from: com.baidu.location.b.b

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location.b']/interface[@name='b']/field[@name='a']"
		[Register ("a")]
		public const bool A = (bool) false;
	}

	[global::System.Obsolete ("Use the 'F' type. This type will be removed in a future release.")]
	public abstract class FConsts : F {

		private FConsts ()
		{
		}
	}

}
