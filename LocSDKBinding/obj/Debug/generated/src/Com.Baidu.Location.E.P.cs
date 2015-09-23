using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Location.E {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.location.e']/class[@name='p']"
	[global::Android.Runtime.Register ("com/baidu/location/e/p", DoNotGenerateAcw=true)]
	public partial class P : global::Java.Lang.Object {


		public static class InterfaceConsts {

			// The following are fields from: com.baidu.location.b.f

			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location.b']/interface[@name='f']/field[@name='bg']"
			[Register ("bg")]
			public const string Bg = (string) "6.1.1";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location.b']/interface[@name='f']/field[@name='bh']"
			[Register ("bh")]
			public const int Bh = (int) 6;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location.b']/interface[@name='f']/field[@name='bi']"
			[Register ("bi")]
			public const float Bi = (float) 6.110000;

			// The following are fields from: com.baidu.location.b.b

			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location.b']/interface[@name='b']/field[@name='a']"
			[Register ("a")]
			public const bool A = (bool) false;
		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.baidu.location.e']/interface[@name='p.a']"
		[Register ("com/baidu/location/e/p$a", "", "Com.Baidu.Location.E.P/IAInvoker")]
		public partial interface IA : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location.e']/interface[@name='p.a']/method[@name='onReceiveLocation' and count(parameter)=1 and parameter[1][@type='com.baidu.location.BDLocation']]"
			[Register ("onReceiveLocation", "(Lcom/baidu/location/BDLocation;)V", "GetOnReceiveLocation_Lcom_baidu_location_BDLocation_Handler:Com.Baidu.Location.E.P/IAInvoker, LocSDKBinding")]
			void OnReceiveLocation (global::Com.Baidu.Location.BDLocation p0);

		}

		[global::Android.Runtime.Register ("com/baidu/location/e/p$a", DoNotGenerateAcw=true)]
		internal class IAInvoker : global::Java.Lang.Object, IA {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/baidu/location/e/p$a");
			IntPtr class_ref;

			public static IA GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IA> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.baidu.location.e.p.a"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IAInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IAInvoker); }
			}

			static Delegate cb_onReceiveLocation_Lcom_baidu_location_BDLocation_;
#pragma warning disable 0169
			static Delegate GetOnReceiveLocation_Lcom_baidu_location_BDLocation_Handler ()
			{
				if (cb_onReceiveLocation_Lcom_baidu_location_BDLocation_ == null)
					cb_onReceiveLocation_Lcom_baidu_location_BDLocation_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnReceiveLocation_Lcom_baidu_location_BDLocation_);
				return cb_onReceiveLocation_Lcom_baidu_location_BDLocation_;
			}

			static void n_OnReceiveLocation_Lcom_baidu_location_BDLocation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Baidu.Location.E.P.IA __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Location.E.P.IA> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Baidu.Location.BDLocation p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Location.BDLocation> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnReceiveLocation (p0);
			}
#pragma warning restore 0169

			IntPtr id_onReceiveLocation_Lcom_baidu_location_BDLocation_;
			public unsafe void OnReceiveLocation (global::Com.Baidu.Location.BDLocation p0)
			{
				if (id_onReceiveLocation_Lcom_baidu_location_BDLocation_ == IntPtr.Zero)
					id_onReceiveLocation_Lcom_baidu_location_BDLocation_ = JNIEnv.GetMethodID (class_ref, "onReceiveLocation", "(Lcom/baidu/location/BDLocation;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (Handle, id_onReceiveLocation_Lcom_baidu_location_BDLocation_, __args);
			}

		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/location/e/p", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (P); }
		}

		protected P (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Lcom_baidu_location_LocationClientOption_Lcom_baidu_location_e_p_a_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.location.e']/class[@name='p']/constructor[@name='p' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.baidu.location.LocationClientOption'] and parameter[3][@type='com.baidu.location.e.p.a']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/baidu/location/LocationClientOption;Lcom/baidu/location/e/p$a;)V", "")]
		public unsafe P (global::Android.Content.Context p0, global::Com.Baidu.Location.LocationClientOption p1, global::Com.Baidu.Location.E.P.IA p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (P)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Lcom/baidu/location/LocationClientOption;Lcom/baidu/location/e/p$a;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Lcom/baidu/location/LocationClientOption;Lcom/baidu/location/e/p$a;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Lcom_baidu_location_LocationClientOption_Lcom_baidu_location_e_p_a_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Lcom_baidu_location_LocationClientOption_Lcom_baidu_location_e_p_a_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Lcom/baidu/location/LocationClientOption;Lcom/baidu/location/e/p$a;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Lcom_baidu_location_LocationClientOption_Lcom_baidu_location_e_p_a_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Lcom_baidu_location_LocationClientOption_Lcom_baidu_location_e_p_a_, __args);
			} finally {
			}
		}

		static Delegate cb_char_I;
#pragma warning disable 0169
		static Delegate GetChar_IHandler ()
		{
			if (cb_char_I == null)
				cb_char_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_Char_I);
			return cb_char_I;
		}

		static IntPtr n_Char_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Baidu.Location.E.P __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Location.E.P> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Char (p0));
		}
#pragma warning restore 0169

		static IntPtr id_char_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location.e']/class[@name='p']/method[@name='char' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("char", "(I)Ljava/lang/String;", "GetChar_IHandler")]
		public virtual unsafe string Char (int p0)
		{
			if (id_char_I == IntPtr.Zero)
				id_char_I = JNIEnv.GetMethodID (class_ref, "char", "(I)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_char_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "char", "(I)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_cr;
#pragma warning disable 0169
		static Delegate GetCrHandler ()
		{
			if (cb_cr == null)
				cb_cr = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Cr);
			return cb_cr;
		}

		static void n_Cr (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Location.E.P __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Location.E.P> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Cr ();
		}
#pragma warning restore 0169

		static IntPtr id_cr;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location.e']/class[@name='p']/method[@name='cr' and count(parameter)=0]"
		[Register ("cr", "()V", "GetCrHandler")]
		public virtual unsafe void Cr ()
		{
			if (id_cr == IntPtr.Zero)
				id_cr = JNIEnv.GetMethodID (class_ref, "cr", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_cr);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "cr", "()V"));
			} finally {
			}
		}

		static Delegate cb_cs;
#pragma warning disable 0169
		static Delegate GetCsHandler ()
		{
			if (cb_cs == null)
				cb_cs = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Cs);
			return cb_cs;
		}

		static IntPtr n_Cs (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Location.E.P __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Location.E.P> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Cs ());
		}
#pragma warning restore 0169

		static IntPtr id_cs;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location.e']/class[@name='p']/method[@name='cs' and count(parameter)=0]"
		[Register ("cs", "()Ljava/lang/String;", "GetCsHandler")]
		public virtual unsafe string Cs ()
		{
			if (id_cs == IntPtr.Zero)
				id_cs = JNIEnv.GetMethodID (class_ref, "cs", "()Ljava/lang/String;");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_cs), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "cs", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_ct;
#pragma warning disable 0169
		static Delegate GetCtHandler ()
		{
			if (cb_ct == null)
				cb_ct = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Ct);
			return cb_ct;
		}

		static IntPtr n_Ct (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Location.E.P __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Location.E.P> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Ct ());
		}
#pragma warning restore 0169

		static IntPtr id_ct;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location.e']/class[@name='p']/method[@name='ct' and count(parameter)=0]"
		[Register ("ct", "()Ljava/lang/String;", "GetCtHandler")]
		public virtual unsafe string Ct ()
		{
			if (id_ct == IntPtr.Zero)
				id_ct = JNIEnv.GetMethodID (class_ref, "ct", "()Ljava/lang/String;");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_ct), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "ct", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
