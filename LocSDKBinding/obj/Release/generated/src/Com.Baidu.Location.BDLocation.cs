using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Location {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']"
	[global::Android.Runtime.Register ("com/baidu/location/BDLocation", DoNotGenerateAcw=true)]
	public sealed partial class BDLocation : global::Java.Lang.Object, global::Android.OS.IParcelable {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/field[@name='BDLOCATION_BD09LL_TO_GCJ02']"
		[Register ("BDLOCATION_BD09LL_TO_GCJ02")]
		public const string BdlocationBd09llToGcj02 = (string) "bd09ll2gcj";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/field[@name='BDLOCATION_BD09_TO_GCJ02']"
		[Register ("BDLOCATION_BD09_TO_GCJ02")]
		public const string BdlocationBd09ToGcj02 = (string) "bd092gcj";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/field[@name='BDLOCATION_GCJ02_TO_BD09']"
		[Register ("BDLOCATION_GCJ02_TO_BD09")]
		public const string BdlocationGcj02ToBd09 = (string) "bd09";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/field[@name='BDLOCATION_GCJ02_TO_BD09LL']"
		[Register ("BDLOCATION_GCJ02_TO_BD09LL")]
		public const string BdlocationGcj02ToBd09ll = (string) "bd09ll";

		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				if (CREATOR_jfieldId == IntPtr.Zero)
					CREATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATOR", "Landroid/os/Parcelable$Creator;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CREATOR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/field[@name='LOCATION_WHERE_IN_CN']"
		[Register ("LOCATION_WHERE_IN_CN")]
		public const int LocationWhereInCn = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/field[@name='LOCATION_WHERE_OUT_CN']"
		[Register ("LOCATION_WHERE_OUT_CN")]
		public const int LocationWhereOutCn = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/field[@name='LOCATION_WHERE_UNKNOW']"
		[Register ("LOCATION_WHERE_UNKNOW")]
		public const int LocationWhereUnknow = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/field[@name='OPERATORS_TYPE_MOBILE']"
		[Register ("OPERATORS_TYPE_MOBILE")]
		public const int OperatorsTypeMobile = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/field[@name='OPERATORS_TYPE_TELECOMU']"
		[Register ("OPERATORS_TYPE_TELECOMU")]
		public const int OperatorsTypeTelecomu = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/field[@name='OPERATORS_TYPE_UNICOM']"
		[Register ("OPERATORS_TYPE_UNICOM")]
		public const int OperatorsTypeUnicom = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/field[@name='OPERATORS_TYPE_UNKONW']"
		[Register ("OPERATORS_TYPE_UNKONW")]
		public const int OperatorsTypeUnkonw = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/field[@name='TypeCacheLocation']"
		[Register ("TypeCacheLocation")]
		public const int TypeCacheLocation = (int) 65;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/field[@name='TypeCriteriaException']"
		[Register ("TypeCriteriaException")]
		public const int TypeCriteriaException = (int) 62;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/field[@name='TypeGpsLocation']"
		[Register ("TypeGpsLocation")]
		public const int TypeGpsLocation = (int) 61;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/field[@name='TypeNetWorkException']"
		[Register ("TypeNetWorkException")]
		public const int TypeNetWorkException = (int) 63;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/field[@name='TypeNetWorkLocation']"
		[Register ("TypeNetWorkLocation")]
		public const int TypeNetWorkLocation = (int) 161;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/field[@name='TypeNone']"
		[Register ("TypeNone")]
		public const int TypeNone = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/field[@name='TypeOffLineLocation']"
		[Register ("TypeOffLineLocation")]
		public const int TypeOffLineLocation = (int) 66;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/field[@name='TypeOffLineLocationFail']"
		[Register ("TypeOffLineLocationFail")]
		public const int TypeOffLineLocationFail = (int) 67;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/field[@name='TypeOffLineLocationNetworkFail']"
		[Register ("TypeOffLineLocationNetworkFail")]
		public const int TypeOffLineLocationNetworkFail = (int) 68;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/field[@name='TypeServerError']"
		[Register ("TypeServerError")]
		public const int TypeServerError = (int) 167;

		public static class InterfaceConsts {

			// The following are fields from: com.baidu.location.b.f

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

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/location/BDLocation", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BDLocation); }
		}

		internal BDLocation (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/constructor[@name='BDLocation' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BDLocation ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (BDLocation)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static IntPtr id_ctor_Lcom_baidu_location_BDLocation_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/constructor[@name='BDLocation' and count(parameter)=1 and parameter[1][@type='com.baidu.location.BDLocation']]"
		[Register (".ctor", "(Lcom/baidu/location/BDLocation;)V", "")]
		public unsafe BDLocation (global::Com.Baidu.Location.BDLocation p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (BDLocation)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/baidu/location/BDLocation;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/baidu/location/BDLocation;)V", __args);
					return;
				}

				if (id_ctor_Lcom_baidu_location_BDLocation_ == IntPtr.Zero)
					id_ctor_Lcom_baidu_location_BDLocation_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/baidu/location/BDLocation;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_baidu_location_BDLocation_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_baidu_location_BDLocation_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/constructor[@name='BDLocation' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe BDLocation (string p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (GetType () != typeof (BDLocation)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_getAddrStr;
		static IntPtr id_setAddrStr_Ljava_lang_String_;
		public unsafe string AddrStr {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='getAddrStr' and count(parameter)=0]"
			[Register ("getAddrStr", "()Ljava/lang/String;", "GetGetAddrStrHandler")]
			get {
				if (id_getAddrStr == IntPtr.Zero)
					id_getAddrStr = JNIEnv.GetMethodID (class_ref, "getAddrStr", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getAddrStr), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='setAddrStr' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAddrStr", "(Ljava/lang/String;)V", "GetSetAddrStr_Ljava_lang_String_Handler")]
			set {
				if (id_setAddrStr_Ljava_lang_String_ == IntPtr.Zero)
					id_setAddrStr_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAddrStr", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);
					JNIEnv.CallVoidMethod  (Handle, id_setAddrStr_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr id_getAddress;
		public unsafe global::Com.Baidu.Location.Address Address {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='getAddress' and count(parameter)=0]"
			[Register ("getAddress", "()Lcom/baidu/location/Address;", "GetGetAddressHandler")]
			get {
				if (id_getAddress == IntPtr.Zero)
					id_getAddress = JNIEnv.GetMethodID (class_ref, "getAddress", "()Lcom/baidu/location/Address;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Location.Address> (JNIEnv.CallObjectMethod  (Handle, id_getAddress), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getAltitude;
		static IntPtr id_setAltitude_D;
		public unsafe double Altitude {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='getAltitude' and count(parameter)=0]"
			[Register ("getAltitude", "()D", "GetGetAltitudeHandler")]
			get {
				if (id_getAltitude == IntPtr.Zero)
					id_getAltitude = JNIEnv.GetMethodID (class_ref, "getAltitude", "()D");
				try {
					return JNIEnv.CallDoubleMethod  (Handle, id_getAltitude);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='setAltitude' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setAltitude", "(D)V", "GetSetAltitude_DHandler")]
			set {
				if (id_setAltitude_D == IntPtr.Zero)
					id_setAltitude_D = JNIEnv.GetMethodID (class_ref, "setAltitude", "(D)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod  (Handle, id_setAltitude_D, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getBuildingID;
		static IntPtr id_setBuildingID_Ljava_lang_String_;
		public unsafe string BuildingID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='getBuildingID' and count(parameter)=0]"
			[Register ("getBuildingID", "()Ljava/lang/String;", "GetGetBuildingIDHandler")]
			get {
				if (id_getBuildingID == IntPtr.Zero)
					id_getBuildingID = JNIEnv.GetMethodID (class_ref, "getBuildingID", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getBuildingID), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='setBuildingID' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setBuildingID", "(Ljava/lang/String;)V", "GetSetBuildingID_Ljava_lang_String_Handler")]
			set {
				if (id_setBuildingID_Ljava_lang_String_ == IntPtr.Zero)
					id_setBuildingID_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setBuildingID", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);
					JNIEnv.CallVoidMethod  (Handle, id_setBuildingID_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr id_getBuildingName;
		static IntPtr id_setBuildingName_Ljava_lang_String_;
		public unsafe string BuildingName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='getBuildingName' and count(parameter)=0]"
			[Register ("getBuildingName", "()Ljava/lang/String;", "GetGetBuildingNameHandler")]
			get {
				if (id_getBuildingName == IntPtr.Zero)
					id_getBuildingName = JNIEnv.GetMethodID (class_ref, "getBuildingName", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getBuildingName), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='setBuildingName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setBuildingName", "(Ljava/lang/String;)V", "GetSetBuildingName_Ljava_lang_String_Handler")]
			set {
				if (id_setBuildingName_Ljava_lang_String_ == IntPtr.Zero)
					id_setBuildingName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setBuildingName", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);
					JNIEnv.CallVoidMethod  (Handle, id_setBuildingName_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr id_getCity;
		public unsafe string City {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='getCity' and count(parameter)=0]"
			[Register ("getCity", "()Ljava/lang/String;", "GetGetCityHandler")]
			get {
				if (id_getCity == IntPtr.Zero)
					id_getCity = JNIEnv.GetMethodID (class_ref, "getCity", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getCity), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getCityCode;
		public unsafe string CityCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='getCityCode' and count(parameter)=0]"
			[Register ("getCityCode", "()Ljava/lang/String;", "GetGetCityCodeHandler")]
			get {
				if (id_getCityCode == IntPtr.Zero)
					id_getCityCode = JNIEnv.GetMethodID (class_ref, "getCityCode", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getCityCode), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getCoorType;
		static IntPtr id_setCoorType_Ljava_lang_String_;
		public unsafe string CoorType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='getCoorType' and count(parameter)=0]"
			[Register ("getCoorType", "()Ljava/lang/String;", "GetGetCoorTypeHandler")]
			get {
				if (id_getCoorType == IntPtr.Zero)
					id_getCoorType = JNIEnv.GetMethodID (class_ref, "getCoorType", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getCoorType), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='setCoorType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCoorType", "(Ljava/lang/String;)V", "GetSetCoorType_Ljava_lang_String_Handler")]
			set {
				if (id_setCoorType_Ljava_lang_String_ == IntPtr.Zero)
					id_setCoorType_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setCoorType", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);
					JNIEnv.CallVoidMethod  (Handle, id_setCoorType_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr id_getCountry;
		public unsafe string Country {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='getCountry' and count(parameter)=0]"
			[Register ("getCountry", "()Ljava/lang/String;", "GetGetCountryHandler")]
			get {
				if (id_getCountry == IntPtr.Zero)
					id_getCountry = JNIEnv.GetMethodID (class_ref, "getCountry", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getCountry), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getCountryCode;
		public unsafe string CountryCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='getCountryCode' and count(parameter)=0]"
			[Register ("getCountryCode", "()Ljava/lang/String;", "GetGetCountryCodeHandler")]
			get {
				if (id_getCountryCode == IntPtr.Zero)
					id_getCountryCode = JNIEnv.GetMethodID (class_ref, "getCountryCode", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getCountryCode), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getDerect;
		public unsafe float Derect {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='getDerect' and count(parameter)=0]"
			[Register ("getDerect", "()F", "GetGetDerectHandler")]
			get {
				if (id_getDerect == IntPtr.Zero)
					id_getDerect = JNIEnv.GetMethodID (class_ref, "getDerect", "()F");
				try {
					return JNIEnv.CallFloatMethod  (Handle, id_getDerect);
				} finally {
				}
			}
		}

		static IntPtr id_getDirection;
		static IntPtr id_setDirection_F;
		public unsafe float Direction {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='getDirection' and count(parameter)=0]"
			[Register ("getDirection", "()F", "GetGetDirectionHandler")]
			get {
				if (id_getDirection == IntPtr.Zero)
					id_getDirection = JNIEnv.GetMethodID (class_ref, "getDirection", "()F");
				try {
					return JNIEnv.CallFloatMethod  (Handle, id_getDirection);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='setDirection' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setDirection", "(F)V", "GetSetDirection_FHandler")]
			set {
				if (id_setDirection_F == IntPtr.Zero)
					id_setDirection_F = JNIEnv.GetMethodID (class_ref, "setDirection", "(F)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod  (Handle, id_setDirection_F, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getDistrict;
		public unsafe string District {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='getDistrict' and count(parameter)=0]"
			[Register ("getDistrict", "()Ljava/lang/String;", "GetGetDistrictHandler")]
			get {
				if (id_getDistrict == IntPtr.Zero)
					id_getDistrict = JNIEnv.GetMethodID (class_ref, "getDistrict", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getDistrict), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getFloor;
		static IntPtr id_setFloor_Ljava_lang_String_;
		public unsafe string Floor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='getFloor' and count(parameter)=0]"
			[Register ("getFloor", "()Ljava/lang/String;", "GetGetFloorHandler")]
			get {
				if (id_getFloor == IntPtr.Zero)
					id_getFloor = JNIEnv.GetMethodID (class_ref, "getFloor", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getFloor), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='setFloor' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setFloor", "(Ljava/lang/String;)V", "GetSetFloor_Ljava_lang_String_Handler")]
			set {
				if (id_setFloor_Ljava_lang_String_ == IntPtr.Zero)
					id_setFloor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setFloor", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);
					JNIEnv.CallVoidMethod  (Handle, id_setFloor_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr id_hasAddr;
		public unsafe bool HasAddr {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='hasAddr' and count(parameter)=0]"
			[Register ("hasAddr", "()Z", "GetHasAddrHandler")]
			get {
				if (id_hasAddr == IntPtr.Zero)
					id_hasAddr = JNIEnv.GetMethodID (class_ref, "hasAddr", "()Z");
				try {
					return JNIEnv.CallBooleanMethod  (Handle, id_hasAddr);
				} finally {
				}
			}
		}

		static IntPtr id_hasAltitude;
		public unsafe bool HasAltitude {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='hasAltitude' and count(parameter)=0]"
			[Register ("hasAltitude", "()Z", "GetHasAltitudeHandler")]
			get {
				if (id_hasAltitude == IntPtr.Zero)
					id_hasAltitude = JNIEnv.GetMethodID (class_ref, "hasAltitude", "()Z");
				try {
					return JNIEnv.CallBooleanMethod  (Handle, id_hasAltitude);
				} finally {
				}
			}
		}

		static IntPtr id_hasRadius;
		public unsafe bool HasRadius {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='hasRadius' and count(parameter)=0]"
			[Register ("hasRadius", "()Z", "GetHasRadiusHandler")]
			get {
				if (id_hasRadius == IntPtr.Zero)
					id_hasRadius = JNIEnv.GetMethodID (class_ref, "hasRadius", "()Z");
				try {
					return JNIEnv.CallBooleanMethod  (Handle, id_hasRadius);
				} finally {
				}
			}
		}

		static IntPtr id_hasSateNumber;
		public unsafe bool HasSateNumber {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='hasSateNumber' and count(parameter)=0]"
			[Register ("hasSateNumber", "()Z", "GetHasSateNumberHandler")]
			get {
				if (id_hasSateNumber == IntPtr.Zero)
					id_hasSateNumber = JNIEnv.GetMethodID (class_ref, "hasSateNumber", "()Z");
				try {
					return JNIEnv.CallBooleanMethod  (Handle, id_hasSateNumber);
				} finally {
				}
			}
		}

		static IntPtr id_hasSpeed;
		public unsafe bool HasSpeed {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='hasSpeed' and count(parameter)=0]"
			[Register ("hasSpeed", "()Z", "GetHasSpeedHandler")]
			get {
				if (id_hasSpeed == IntPtr.Zero)
					id_hasSpeed = JNIEnv.GetMethodID (class_ref, "hasSpeed", "()Z");
				try {
					return JNIEnv.CallBooleanMethod  (Handle, id_hasSpeed);
				} finally {
				}
			}
		}

		static IntPtr id_isIndoorLocMode;
		static IntPtr id_setIndoorLocMode_Z;
		public unsafe bool IndoorLocMode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='isIndoorLocMode' and count(parameter)=0]"
			[Register ("isIndoorLocMode", "()Z", "GetIsIndoorLocModeHandler")]
			get {
				if (id_isIndoorLocMode == IntPtr.Zero)
					id_isIndoorLocMode = JNIEnv.GetMethodID (class_ref, "isIndoorLocMode", "()Z");
				try {
					return JNIEnv.CallBooleanMethod  (Handle, id_isIndoorLocMode);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='setIndoorLocMode' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setIndoorLocMode", "(Z)V", "GetSetIndoorLocMode_ZHandler")]
			set {
				if (id_setIndoorLocMode_Z == IntPtr.Zero)
					id_setIndoorLocMode_Z = JNIEnv.GetMethodID (class_ref, "setIndoorLocMode", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod  (Handle, id_setIndoorLocMode_Z, __args);
				} finally {
				}
			}
		}

		static IntPtr id_isCellChangeFlag;
		public unsafe bool IsCellChangeFlag {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='isCellChangeFlag' and count(parameter)=0]"
			[Register ("isCellChangeFlag", "()Z", "GetIsCellChangeFlagHandler")]
			get {
				if (id_isCellChangeFlag == IntPtr.Zero)
					id_isCellChangeFlag = JNIEnv.GetMethodID (class_ref, "isCellChangeFlag", "()Z");
				try {
					return JNIEnv.CallBooleanMethod  (Handle, id_isCellChangeFlag);
				} finally {
				}
			}
		}

		static IntPtr id_getLatitude;
		static IntPtr id_setLatitude_D;
		public unsafe double Latitude {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='getLatitude' and count(parameter)=0]"
			[Register ("getLatitude", "()D", "GetGetLatitudeHandler")]
			get {
				if (id_getLatitude == IntPtr.Zero)
					id_getLatitude = JNIEnv.GetMethodID (class_ref, "getLatitude", "()D");
				try {
					return JNIEnv.CallDoubleMethod  (Handle, id_getLatitude);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='setLatitude' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setLatitude", "(D)V", "GetSetLatitude_DHandler")]
			set {
				if (id_setLatitude_D == IntPtr.Zero)
					id_setLatitude_D = JNIEnv.GetMethodID (class_ref, "setLatitude", "(D)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod  (Handle, id_setLatitude_D, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getLocType;
		static IntPtr id_setLocType_I;
		public unsafe int LocType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='getLocType' and count(parameter)=0]"
			[Register ("getLocType", "()I", "GetGetLocTypeHandler")]
			get {
				if (id_getLocType == IntPtr.Zero)
					id_getLocType = JNIEnv.GetMethodID (class_ref, "getLocType", "()I");
				try {
					return JNIEnv.CallIntMethod  (Handle, id_getLocType);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='setLocType' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setLocType", "(I)V", "GetSetLocType_IHandler")]
			set {
				if (id_setLocType_I == IntPtr.Zero)
					id_setLocType_I = JNIEnv.GetMethodID (class_ref, "setLocType", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod  (Handle, id_setLocType_I, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getLocationDescribe;
		static IntPtr id_setLocationDescribe_Ljava_lang_String_;
		public unsafe string LocationDescribe {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='getLocationDescribe' and count(parameter)=0]"
			[Register ("getLocationDescribe", "()Ljava/lang/String;", "GetGetLocationDescribeHandler")]
			get {
				if (id_getLocationDescribe == IntPtr.Zero)
					id_getLocationDescribe = JNIEnv.GetMethodID (class_ref, "getLocationDescribe", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getLocationDescribe), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='setLocationDescribe' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setLocationDescribe", "(Ljava/lang/String;)V", "GetSetLocationDescribe_Ljava_lang_String_Handler")]
			set {
				if (id_setLocationDescribe_Ljava_lang_String_ == IntPtr.Zero)
					id_setLocationDescribe_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setLocationDescribe", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);
					JNIEnv.CallVoidMethod  (Handle, id_setLocationDescribe_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr id_getLocationWhere;
		static IntPtr id_setLocationWhere_I;
		public unsafe int LocationWhere {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='getLocationWhere' and count(parameter)=0]"
			[Register ("getLocationWhere", "()I", "GetGetLocationWhereHandler")]
			get {
				if (id_getLocationWhere == IntPtr.Zero)
					id_getLocationWhere = JNIEnv.GetMethodID (class_ref, "getLocationWhere", "()I");
				try {
					return JNIEnv.CallIntMethod  (Handle, id_getLocationWhere);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='setLocationWhere' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setLocationWhere", "(I)V", "GetSetLocationWhere_IHandler")]
			set {
				if (id_setLocationWhere_I == IntPtr.Zero)
					id_setLocationWhere_I = JNIEnv.GetMethodID (class_ref, "setLocationWhere", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod  (Handle, id_setLocationWhere_I, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getLongitude;
		static IntPtr id_setLongitude_D;
		public unsafe double Longitude {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='getLongitude' and count(parameter)=0]"
			[Register ("getLongitude", "()D", "GetGetLongitudeHandler")]
			get {
				if (id_getLongitude == IntPtr.Zero)
					id_getLongitude = JNIEnv.GetMethodID (class_ref, "getLongitude", "()D");
				try {
					return JNIEnv.CallDoubleMethod  (Handle, id_getLongitude);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='setLongitude' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setLongitude", "(D)V", "GetSetLongitude_DHandler")]
			set {
				if (id_setLongitude_D == IntPtr.Zero)
					id_setLongitude_D = JNIEnv.GetMethodID (class_ref, "setLongitude", "(D)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod  (Handle, id_setLongitude_D, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getNetworkLocationType;
		static IntPtr id_setNetworkLocationType_Ljava_lang_String_;
		public unsafe string NetworkLocationType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='getNetworkLocationType' and count(parameter)=0]"
			[Register ("getNetworkLocationType", "()Ljava/lang/String;", "GetGetNetworkLocationTypeHandler")]
			get {
				if (id_getNetworkLocationType == IntPtr.Zero)
					id_getNetworkLocationType = JNIEnv.GetMethodID (class_ref, "getNetworkLocationType", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getNetworkLocationType), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='setNetworkLocationType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setNetworkLocationType", "(Ljava/lang/String;)V", "GetSetNetworkLocationType_Ljava_lang_String_Handler")]
			set {
				if (id_setNetworkLocationType_Ljava_lang_String_ == IntPtr.Zero)
					id_setNetworkLocationType_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setNetworkLocationType", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);
					JNIEnv.CallVoidMethod  (Handle, id_setNetworkLocationType_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr id_getOperators;
		static IntPtr id_setOperators_I;
		public unsafe int Operators {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='getOperators' and count(parameter)=0]"
			[Register ("getOperators", "()I", "GetGetOperatorsHandler")]
			get {
				if (id_getOperators == IntPtr.Zero)
					id_getOperators = JNIEnv.GetMethodID (class_ref, "getOperators", "()I");
				try {
					return JNIEnv.CallIntMethod  (Handle, id_getOperators);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='setOperators' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setOperators", "(I)V", "GetSetOperators_IHandler")]
			set {
				if (id_setOperators_I == IntPtr.Zero)
					id_setOperators_I = JNIEnv.GetMethodID (class_ref, "setOperators", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod  (Handle, id_setOperators_I, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getPoiList;
		static IntPtr id_setPoiList_Ljava_util_List_;
		public unsafe global::System.Collections.IList PoiList {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='getPoiList' and count(parameter)=0]"
			[Register ("getPoiList", "()Ljava/util/List;", "GetGetPoiListHandler")]
			get {
				if (id_getPoiList == IntPtr.Zero)
					id_getPoiList = JNIEnv.GetMethodID (class_ref, "getPoiList", "()Ljava/util/List;");
				try {
					return global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getPoiList), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='setPoiList' and count(parameter)=1 and parameter[1][@type='java.util.List']]"
			[Register ("setPoiList", "(Ljava/util/List;)V", "GetSetPoiList_Ljava_util_List_Handler")]
			set {
				if (id_setPoiList_Ljava_util_List_ == IntPtr.Zero)
					id_setPoiList_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setPoiList", "(Ljava/util/List;)V");
				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);
					JNIEnv.CallVoidMethod  (Handle, id_setPoiList_Ljava_util_List_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr id_getProvince;
		public unsafe string Province {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='getProvince' and count(parameter)=0]"
			[Register ("getProvince", "()Ljava/lang/String;", "GetGetProvinceHandler")]
			get {
				if (id_getProvince == IntPtr.Zero)
					id_getProvince = JNIEnv.GetMethodID (class_ref, "getProvince", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getProvince), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getRadius;
		static IntPtr id_setRadius_F;
		public unsafe float Radius {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='getRadius' and count(parameter)=0]"
			[Register ("getRadius", "()F", "GetGetRadiusHandler")]
			get {
				if (id_getRadius == IntPtr.Zero)
					id_getRadius = JNIEnv.GetMethodID (class_ref, "getRadius", "()F");
				try {
					return JNIEnv.CallFloatMethod  (Handle, id_getRadius);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='setRadius' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setRadius", "(F)V", "GetSetRadius_FHandler")]
			set {
				if (id_setRadius_F == IntPtr.Zero)
					id_setRadius_F = JNIEnv.GetMethodID (class_ref, "setRadius", "(F)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod  (Handle, id_setRadius_F, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getSatelliteNumber;
		static IntPtr id_setSatelliteNumber_I;
		public unsafe int SatelliteNumber {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='getSatelliteNumber' and count(parameter)=0]"
			[Register ("getSatelliteNumber", "()I", "GetGetSatelliteNumberHandler")]
			get {
				if (id_getSatelliteNumber == IntPtr.Zero)
					id_getSatelliteNumber = JNIEnv.GetMethodID (class_ref, "getSatelliteNumber", "()I");
				try {
					return JNIEnv.CallIntMethod  (Handle, id_getSatelliteNumber);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='setSatelliteNumber' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setSatelliteNumber", "(I)V", "GetSetSatelliteNumber_IHandler")]
			set {
				if (id_setSatelliteNumber_I == IntPtr.Zero)
					id_setSatelliteNumber_I = JNIEnv.GetMethodID (class_ref, "setSatelliteNumber", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod  (Handle, id_setSatelliteNumber_I, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getSemaAptag;
		public unsafe string SemaAptag {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='getSemaAptag' and count(parameter)=0]"
			[Register ("getSemaAptag", "()Ljava/lang/String;", "GetGetSemaAptagHandler")]
			get {
				if (id_getSemaAptag == IntPtr.Zero)
					id_getSemaAptag = JNIEnv.GetMethodID (class_ref, "getSemaAptag", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getSemaAptag), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getSpeed;
		static IntPtr id_setSpeed_F;
		public unsafe float Speed {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='getSpeed' and count(parameter)=0]"
			[Register ("getSpeed", "()F", "GetGetSpeedHandler")]
			get {
				if (id_getSpeed == IntPtr.Zero)
					id_getSpeed = JNIEnv.GetMethodID (class_ref, "getSpeed", "()F");
				try {
					return JNIEnv.CallFloatMethod  (Handle, id_getSpeed);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='setSpeed' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setSpeed", "(F)V", "GetSetSpeed_FHandler")]
			set {
				if (id_setSpeed_F == IntPtr.Zero)
					id_setSpeed_F = JNIEnv.GetMethodID (class_ref, "setSpeed", "(F)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod  (Handle, id_setSpeed_F, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getStreet;
		public unsafe string Street {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='getStreet' and count(parameter)=0]"
			[Register ("getStreet", "()Ljava/lang/String;", "GetGetStreetHandler")]
			get {
				if (id_getStreet == IntPtr.Zero)
					id_getStreet = JNIEnv.GetMethodID (class_ref, "getStreet", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getStreet), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getStreetNumber;
		public unsafe string StreetNumber {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='getStreetNumber' and count(parameter)=0]"
			[Register ("getStreetNumber", "()Ljava/lang/String;", "GetGetStreetNumberHandler")]
			get {
				if (id_getStreetNumber == IntPtr.Zero)
					id_getStreetNumber = JNIEnv.GetMethodID (class_ref, "getStreetNumber", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getStreetNumber), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getTime;
		static IntPtr id_setTime_Ljava_lang_String_;
		public unsafe string Time {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='getTime' and count(parameter)=0]"
			[Register ("getTime", "()Ljava/lang/String;", "GetGetTimeHandler")]
			get {
				if (id_getTime == IntPtr.Zero)
					id_getTime = JNIEnv.GetMethodID (class_ref, "getTime", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getTime), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='setTime' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTime", "(Ljava/lang/String;)V", "GetSetTime_Ljava_lang_String_Handler")]
			set {
				if (id_setTime_Ljava_lang_String_ == IntPtr.Zero)
					id_setTime_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTime", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);
					JNIEnv.CallVoidMethod  (Handle, id_setTime_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='describeContents' and count(parameter)=0]"
		[Register ("describeContents", "()I", "")]
		public unsafe int DescribeContents ()
		{
			if (id_describeContents == IntPtr.Zero)
				id_describeContents = JNIEnv.GetMethodID (class_ref, "describeContents", "()I");
			try {
				return JNIEnv.CallIntMethod  (Handle, id_describeContents);
			} finally {
			}
		}

		static IntPtr id_getAdUrl_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='getAdUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getAdUrl", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public unsafe string GetAdUrl (string p0)
		{
			if (id_getAdUrl_Ljava_lang_String_ == IntPtr.Zero)
				id_getAdUrl_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getAdUrl", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getAdUrl_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_internalSet_ILjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='internalSet' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("internalSet", "(ILjava/lang/String;)V", "")]
		public unsafe void InternalSet (int p0, string p1)
		{
			if (id_internalSet_ILjava_lang_String_ == IntPtr.Zero)
				id_internalSet_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "internalSet", "(ILjava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallVoidMethod  (Handle, id_internalSet_ILjava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_isParkAvailable;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='isParkAvailable' and count(parameter)=0]"
		[Register ("isParkAvailable", "()I", "")]
		public unsafe int IsParkAvailable ()
		{
			if (id_isParkAvailable == IntPtr.Zero)
				id_isParkAvailable = JNIEnv.GetMethodID (class_ref, "isParkAvailable", "()I");
			try {
				return JNIEnv.CallIntMethod  (Handle, id_isParkAvailable);
			} finally {
			}
		}

		static IntPtr id_setAddr_Lcom_baidu_location_Address_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='setAddr' and count(parameter)=1 and parameter[1][@type='com.baidu.location.Address']]"
		[Register ("setAddr", "(Lcom/baidu/location/Address;)V", "")]
		public unsafe void SetAddr (global::Com.Baidu.Location.Address p0)
		{
			if (id_setAddr_Lcom_baidu_location_Address_ == IntPtr.Zero)
				id_setAddr_Lcom_baidu_location_Address_ = JNIEnv.GetMethodID (class_ref, "setAddr", "(Lcom/baidu/location/Address;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_setAddr_Lcom_baidu_location_Address_, __args);
			} finally {
			}
		}

		static IntPtr id_setParkAvailable_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='setParkAvailable' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setParkAvailable", "(I)V", "")]
		public unsafe void SetParkAvailable (int p0)
		{
			if (id_setParkAvailable_I == IntPtr.Zero)
				id_setParkAvailable_I = JNIEnv.GetMethodID (class_ref, "setParkAvailable", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_setParkAvailable_I, __args);
			} finally {
			}
		}

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "")]
		public unsafe void WriteToParcel (global::Android.OS.Parcel p0, [global::Android.Runtime.GeneratedEnum] global::Android.OS.ParcelableWriteFlags p1)
		{
			if (id_writeToParcel_Landroid_os_Parcel_I == IntPtr.Zero)
				id_writeToParcel_Landroid_os_Parcel_I = JNIEnv.GetMethodID (class_ref, "writeToParcel", "(Landroid/os/Parcel;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue ((int) p1);
				JNIEnv.CallVoidMethod  (Handle, id_writeToParcel_Landroid_os_Parcel_I, __args);
			} finally {
			}
		}

	}
}
