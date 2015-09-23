using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Java.Interop {

	partial class __TypeRegistrations {

		public static void RegisterPackages ()
		{
#if MONODROID_TIMING
			var start = DateTime.Now;
			Android.Util.Log.Info ("MonoDroid-Timing", "RegisterPackages start: " + (start - new DateTime (1970, 1, 1)).TotalMilliseconds);
#endif // def MONODROID_TIMING
			Java.Interop.TypeManager.RegisterPackages (
					new string[]{
						"com/baidu/mapapi/utils",
						"com/baidu/vi",
					},
					new Converter<string, Type>[]{
						lookup_com_baidu_mapapi_utils_package,
						lookup_com_baidu_vi_package,
					});
#if MONODROID_TIMING
			var end = DateTime.Now;
			Android.Util.Log.Info ("MonoDroid-Timing", "RegisterPackages time: " + (end - new DateTime (1970, 1, 1)).TotalMilliseconds + " [elapsed: " + (end - start).TotalMilliseconds + " ms]");
#endif // def MONODROID_TIMING
		}

		static Type Lookup (string[] mappings, string javaType)
		{
			string managedType = Java.Interop.TypeManager.LookupTypeMapping (mappings, javaType);
			if (managedType == null)
				return null;
			return Type.GetType (managedType);
		}

		static string[] package_com_baidu_mapapi_utils_mappings;
		static Type lookup_com_baidu_mapapi_utils_package (string klass)
		{
			if (package_com_baidu_mapapi_utils_mappings == null) {
				package_com_baidu_mapapi_utils_mappings = new string[]{
					"com/baidu/mapapi/utils/PermissionCheck$b:Com.Baidu.Mapapi.Utils.PermissionCheck/b_",
				};
			}

			return Lookup (package_com_baidu_mapapi_utils_mappings, klass);
		}

		static string[] package_com_baidu_vi_mappings;
		static Type lookup_com_baidu_vi_package (string klass)
		{
			if (package_com_baidu_vi_mappings == null) {
				package_com_baidu_vi_mappings = new string[]{
					"com/baidu/vi/c:Com.Baidu.VI.c_",
				};
			}

			return Lookup (package_com_baidu_vi_mappings, klass);
		}
	}
}
