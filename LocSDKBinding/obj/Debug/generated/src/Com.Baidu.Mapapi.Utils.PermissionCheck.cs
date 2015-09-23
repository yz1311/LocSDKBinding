using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Mapapi.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.utils']/class[@name='PermissionCheck']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/utils/PermissionCheck", DoNotGenerateAcw=true)]
	public partial class PermissionCheck : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.utils']/class[@name='PermissionCheck.b']"
		[global::Android.Runtime.Register ("com/baidu/mapapi/utils/PermissionCheck$b", DoNotGenerateAcw=true)]
		public partial class b_ : global::Java.Lang.Object {


			static IntPtr a_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.utils']/class[@name='PermissionCheck.b']/field[@name='a']"
			[Register ("a")]
			public int A {
				get {
					if (a_jfieldId == IntPtr.Zero)
						a_jfieldId = JNIEnv.GetFieldID (class_ref, "a", "I");
					return JNIEnv.GetIntField (Handle, a_jfieldId);
				}
				set {
					if (a_jfieldId == IntPtr.Zero)
						a_jfieldId = JNIEnv.GetFieldID (class_ref, "a", "I");
					try {
						JNIEnv.SetField (Handle, a_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr b_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.utils']/class[@name='PermissionCheck.b']/field[@name='b']"
			[Register ("b")]
			public string B {
				get {
					if (b_jfieldId == IntPtr.Zero)
						b_jfieldId = JNIEnv.GetFieldID (class_ref, "b", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (Handle, b_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (b_jfieldId == IntPtr.Zero)
						b_jfieldId = JNIEnv.GetFieldID (class_ref, "b", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (Handle, b_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr c_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.utils']/class[@name='PermissionCheck.b']/field[@name='c']"
			[Register ("c")]
			public string C {
				get {
					if (c_jfieldId == IntPtr.Zero)
						c_jfieldId = JNIEnv.GetFieldID (class_ref, "c", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (Handle, c_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (c_jfieldId == IntPtr.Zero)
						c_jfieldId = JNIEnv.GetFieldID (class_ref, "c", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (Handle, c_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr d_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.utils']/class[@name='PermissionCheck.b']/field[@name='d']"
			[Register ("d")]
			public string D {
				get {
					if (d_jfieldId == IntPtr.Zero)
						d_jfieldId = JNIEnv.GetFieldID (class_ref, "d", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (Handle, d_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (d_jfieldId == IntPtr.Zero)
						d_jfieldId = JNIEnv.GetFieldID (class_ref, "d", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (Handle, d_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr e_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.utils']/class[@name='PermissionCheck.b']/field[@name='e']"
			[Register ("e")]
			public string E {
				get {
					if (e_jfieldId == IntPtr.Zero)
						e_jfieldId = JNIEnv.GetFieldID (class_ref, "e", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (Handle, e_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (e_jfieldId == IntPtr.Zero)
						e_jfieldId = JNIEnv.GetFieldID (class_ref, "e", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (Handle, e_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/baidu/mapapi/utils/PermissionCheck$b", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (b_); }
			}

			protected b_ (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.utils']/class[@name='PermissionCheck.b']/constructor[@name='PermissionCheck.b' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe b_ ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (b_)) {
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

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.baidu.mapapi.utils']/interface[@name='PermissionCheck.c']"
		[Register ("com/baidu/mapapi/utils/PermissionCheck$c", "", "Com.Baidu.Mapapi.Utils.PermissionCheck/ICInvoker")]
		public partial interface IC : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.utils']/interface[@name='PermissionCheck.c']/method[@name='a' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.utils.PermissionCheck.b']]"
			[Register ("a", "(Lcom/baidu/mapapi/utils/PermissionCheck$b;)V", "GetA_Lcom_baidu_mapapi_utils_PermissionCheck_b_Handler:Com.Baidu.Mapapi.Utils.PermissionCheck/ICInvoker, LocSDKBinding")]
			void A (global::Com.Baidu.Mapapi.Utils.PermissionCheck.b_ p0);

		}

		[global::Android.Runtime.Register ("com/baidu/mapapi/utils/PermissionCheck$c", DoNotGenerateAcw=true)]
		internal class ICInvoker : global::Java.Lang.Object, IC {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/baidu/mapapi/utils/PermissionCheck$c");
			IntPtr class_ref;

			public static IC GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IC> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.baidu.mapapi.utils.PermissionCheck.c"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ICInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ICInvoker); }
			}

			static Delegate cb_a_Lcom_baidu_mapapi_utils_PermissionCheck_b_;
#pragma warning disable 0169
			static Delegate GetA_Lcom_baidu_mapapi_utils_PermissionCheck_b_Handler ()
			{
				if (cb_a_Lcom_baidu_mapapi_utils_PermissionCheck_b_ == null)
					cb_a_Lcom_baidu_mapapi_utils_PermissionCheck_b_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_A_Lcom_baidu_mapapi_utils_PermissionCheck_b_);
				return cb_a_Lcom_baidu_mapapi_utils_PermissionCheck_b_;
			}

			static void n_A_Lcom_baidu_mapapi_utils_PermissionCheck_b_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Baidu.Mapapi.Utils.PermissionCheck.IC __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Utils.PermissionCheck.IC> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Baidu.Mapapi.Utils.PermissionCheck.b_ p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Utils.PermissionCheck.b_> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.A (p0);
			}
#pragma warning restore 0169

			IntPtr id_a_Lcom_baidu_mapapi_utils_PermissionCheck_b_;
			public unsafe void A (global::Com.Baidu.Mapapi.Utils.PermissionCheck.b_ p0)
			{
				if (id_a_Lcom_baidu_mapapi_utils_PermissionCheck_b_ == IntPtr.Zero)
					id_a_Lcom_baidu_mapapi_utils_PermissionCheck_b_ = JNIEnv.GetMethodID (class_ref, "a", "(Lcom/baidu/mapapi/utils/PermissionCheck$b;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (Handle, id_a_Lcom_baidu_mapapi_utils_PermissionCheck_b_, __args);
			}

		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/mapapi/utils/PermissionCheck", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PermissionCheck); }
		}

		protected PermissionCheck (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.utils']/class[@name='PermissionCheck']/constructor[@name='PermissionCheck' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PermissionCheck ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (PermissionCheck)) {
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

		static IntPtr id_destory;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.utils']/class[@name='PermissionCheck']/method[@name='destory' and count(parameter)=0]"
		[Register ("destory", "()V", "")]
		public static unsafe void Destory ()
		{
			if (id_destory == IntPtr.Zero)
				id_destory = JNIEnv.GetStaticMethodID (class_ref, "destory", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_destory);
			} finally {
			}
		}

		static IntPtr id_init_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.utils']/class[@name='PermissionCheck']/method[@name='init' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("init", "(Landroid/content/Context;)V", "")]
		public static unsafe void Init (global::Android.Content.Context p0)
		{
			if (id_init_Landroid_content_Context_ == IntPtr.Zero)
				id_init_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "init", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_init_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static IntPtr id_permissionCheck;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.utils']/class[@name='PermissionCheck']/method[@name='permissionCheck' and count(parameter)=0]"
		[Register ("permissionCheck", "()I", "")]
		public static unsafe int InvokePermissionCheck ()
		{
			if (id_permissionCheck == IntPtr.Zero)
				id_permissionCheck = JNIEnv.GetStaticMethodID (class_ref, "permissionCheck", "()I");
			try {
				return JNIEnv.CallStaticIntMethod  (class_ref, id_permissionCheck);
			} finally {
			}
		}

		static IntPtr id_setPermissionCheckResultListener_Lcom_baidu_mapapi_utils_PermissionCheck_c_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.utils']/class[@name='PermissionCheck']/method[@name='setPermissionCheckResultListener' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.utils.PermissionCheck.c']]"
		[Register ("setPermissionCheckResultListener", "(Lcom/baidu/mapapi/utils/PermissionCheck$c;)V", "")]
		public static unsafe void SetPermissionCheckResultListener (global::Com.Baidu.Mapapi.Utils.PermissionCheck.IC p0)
		{
			if (id_setPermissionCheckResultListener_Lcom_baidu_mapapi_utils_PermissionCheck_c_ == IntPtr.Zero)
				id_setPermissionCheckResultListener_Lcom_baidu_mapapi_utils_PermissionCheck_c_ = JNIEnv.GetStaticMethodID (class_ref, "setPermissionCheckResultListener", "(Lcom/baidu/mapapi/utils/PermissionCheck$c;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setPermissionCheckResultListener_Lcom_baidu_mapapi_utils_PermissionCheck_c_, __args);
			} finally {
			}
		}

	}
}
