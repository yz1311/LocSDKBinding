using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.VI {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.vi']/class[@name='c']"
	[global::Android.Runtime.Register ("com/baidu/vi/c", DoNotGenerateAcw=true)]
	public partial class c_ : global::Java.Lang.Object {


		static IntPtr a_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.vi']/class[@name='c']/field[@name='a']"
		[Register ("a")]
		public string A {
			get {
				if (a_jfieldId == IntPtr.Zero)
					a_jfieldId = JNIEnv.GetFieldID (class_ref, "a", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, a_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (a_jfieldId == IntPtr.Zero)
					a_jfieldId = JNIEnv.GetFieldID (class_ref, "a", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (Handle, a_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr b_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.vi']/class[@name='c']/field[@name='b']"
		[Register ("b")]
		public int B {
			get {
				if (b_jfieldId == IntPtr.Zero)
					b_jfieldId = JNIEnv.GetFieldID (class_ref, "b", "I");
				return JNIEnv.GetIntField (Handle, b_jfieldId);
			}
			set {
				if (b_jfieldId == IntPtr.Zero)
					b_jfieldId = JNIEnv.GetFieldID (class_ref, "b", "I");
				try {
					JNIEnv.SetField (Handle, b_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr c_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.vi']/class[@name='c']/field[@name='c']"
		[Register ("c")]
		public int C {
			get {
				if (c_jfieldId == IntPtr.Zero)
					c_jfieldId = JNIEnv.GetFieldID (class_ref, "c", "I");
				return JNIEnv.GetIntField (Handle, c_jfieldId);
			}
			set {
				if (c_jfieldId == IntPtr.Zero)
					c_jfieldId = JNIEnv.GetFieldID (class_ref, "c", "I");
				try {
					JNIEnv.SetField (Handle, c_jfieldId, value);
				} finally {
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/vi/c", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (c_); }
		}

		protected c_ (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_net_NetworkInfo_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.vi']/class[@name='c']/constructor[@name='c' and count(parameter)=1 and parameter[1][@type='android.net.NetworkInfo']]"
		[Register (".ctor", "(Landroid/net/NetworkInfo;)V", "")]
		public unsafe c_ (global::Android.Net.NetworkInfo p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (c_)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/net/NetworkInfo;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/net/NetworkInfo;)V", __args);
					return;
				}

				if (id_ctor_Landroid_net_NetworkInfo_ == IntPtr.Zero)
					id_ctor_Landroid_net_NetworkInfo_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/net/NetworkInfo;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_net_NetworkInfo_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_net_NetworkInfo_, __args);
			} finally {
			}
		}

	}
}
