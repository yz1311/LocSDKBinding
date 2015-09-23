using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Location {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.location']/class[@name='Jni']"
	[global::Android.Runtime.Register ("com/baidu/location/Jni", DoNotGenerateAcw=true)]
	public partial class Jni : global::Java.Lang.Object {


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
				return JNIEnv.FindClass ("com/baidu/location/Jni", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Jni); }
		}

		protected Jni (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.location']/class[@name='Jni']/constructor[@name='Jni' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Jni ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Jni)) {
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

		static IntPtr id_E_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='Jni']/method[@name='E' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("E", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string E (string p0)
		{
			if (id_E_Ljava_lang_String_ == IntPtr.Zero)
				id_E_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "E", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_E_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_F_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='Jni']/method[@name='F' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("F", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string F (string p0)
		{
			if (id_F_Ljava_lang_String_ == IntPtr.Zero)
				id_F_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "F", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_F_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_G_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='Jni']/method[@name='G' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("G", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string G (string p0)
		{
			if (id_G_Ljava_lang_String_ == IntPtr.Zero)
				id_G_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "G", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_G_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_H_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='Jni']/method[@name='H' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("H", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string H (string p0)
		{
			if (id_H_Ljava_lang_String_ == IntPtr.Zero)
				id_H_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "H", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_H_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_I_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='Jni']/method[@name='I' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("I", "(Ljava/lang/String;)Ljava/lang/Long;", "")]
		public static unsafe global::Java.Lang.Long I (string p0)
		{
			if (id_I_Ljava_lang_String_ == IntPtr.Zero)
				id_I_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "I", "(Ljava/lang/String;)Ljava/lang/Long;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Java.Lang.Long __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (JNIEnv.CallStaticObjectMethod  (class_ref, id_I_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_J_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='Jni']/method[@name='J' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("J", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string J (string p0)
		{
			if (id_J_Ljava_lang_String_ == IntPtr.Zero)
				id_J_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "J", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_J_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_K_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='Jni']/method[@name='K' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("K", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string K (string p0)
		{
			if (id_K_Ljava_lang_String_ == IntPtr.Zero)
				id_K_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "K", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_K_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_L_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='Jni']/method[@name='L' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("L", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string L (string p0)
		{
			if (id_L_Ljava_lang_String_ == IntPtr.Zero)
				id_L_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "L", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_L_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_dG;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='Jni']/method[@name='dG' and count(parameter)=0]"
		[Register ("dG", "()Ljava/lang/String;", "")]
		public static unsafe string DG ()
		{
			if (id_dG == IntPtr.Zero)
				id_dG = JNIEnv.GetStaticMethodID (class_ref, "dG", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_dG), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_if_arrayBarrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='Jni']/method[@name='if' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]']]"
		[Register ("if", "([B[B)Ljava/lang/String;", "")]
		public static unsafe string If (byte[] p0, byte[] p1)
		{
			if (id_if_arrayBarrayB == IntPtr.Zero)
				id_if_arrayBarrayB = JNIEnv.GetStaticMethodID (class_ref, "if", "([B[B)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_if_arrayBarrayB, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static IntPtr id_if_DDLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='Jni']/method[@name='if' and count(parameter)=3 and parameter[1][@type='double'] and parameter[2][@type='double'] and parameter[3][@type='java.lang.String']]"
		[Register ("if", "(DDLjava/lang/String;)[D", "")]
		public static unsafe double[] If (double p0, double p1, string p2)
		{
			if (id_if_DDLjava_lang_String_ == IntPtr.Zero)
				id_if_DDLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "if", "(DDLjava/lang/String;)[D");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				double[] __ret = (double[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_if_DDLjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (double));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_int_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='Jni']/method[@name='int' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("int", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void Int (string p0, string p1)
		{
			if (id_int_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_int_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "int", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_int_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
