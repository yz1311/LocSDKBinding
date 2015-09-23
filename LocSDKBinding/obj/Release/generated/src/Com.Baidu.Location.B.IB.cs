using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Location.B {

	[Register ("com/baidu/location/b/b")]
	public abstract class B {

		internal B ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location.b']/interface[@name='b']/field[@name='a']"
		[Register ("a")]
		public const bool A = (bool) false;
	}

	[global::System.Obsolete ("Use the 'B' type. This type will be removed in a future release.")]
	public abstract class BConsts : B {

		private BConsts ()
		{
		}
	}

}
