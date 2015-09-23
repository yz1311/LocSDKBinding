using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Location.D {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.location.d']/class[@name='a']"
	[global::Android.Runtime.Register ("com/baidu/location/d/a", DoNotGenerateAcw=true)]
	public partial class A : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location.d']/class[@name='a']/field[@name='fA']"
		[Register ("fA")]
		public const string FA = (string) "android.com.baidu.location.TIMER.NOTIFY";

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

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/location/d/a", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (A); }
		}

		protected A (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Lcom_baidu_location_LocationClient_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.location.d']/class[@name='a']/constructor[@name='a' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.baidu.location.LocationClient']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/baidu/location/LocationClient;)V", "")]
		public unsafe A (global::Android.Content.Context p0, global::Com.Baidu.Location.LocationClient p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (A)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Lcom/baidu/location/LocationClient;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Lcom/baidu/location/LocationClient;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Lcom_baidu_location_LocationClient_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Lcom_baidu_location_LocationClient_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Lcom/baidu/location/LocationClient;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Lcom_baidu_location_LocationClient_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Lcom_baidu_location_LocationClient_, __args);
			} finally {
			}
		}

		static Delegate cb_a4;
#pragma warning disable 0169
		static Delegate GetA4Handler ()
		{
			if (cb_a4 == null)
				cb_a4 = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_A4);
			return cb_a4;
		}

		static void n_A4 (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Location.D.A __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Location.D.A> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.A4 ();
		}
#pragma warning restore 0169

		static IntPtr id_a4;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location.d']/class[@name='a']/method[@name='a4' and count(parameter)=0]"
		[Register ("a4", "()V", "GetA4Handler")]
		public virtual unsafe void A4 ()
		{
			if (id_a4 == IntPtr.Zero)
				id_a4 = JNIEnv.GetMethodID (class_ref, "a4", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_a4);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "a4", "()V"));
			} finally {
			}
		}

		static Delegate cb_do_Lcom_baidu_location_BDNotifyListener_;
#pragma warning disable 0169
		static Delegate GetDo_Lcom_baidu_location_BDNotifyListener_Handler ()
		{
			if (cb_do_Lcom_baidu_location_BDNotifyListener_ == null)
				cb_do_Lcom_baidu_location_BDNotifyListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_Do_Lcom_baidu_location_BDNotifyListener_);
			return cb_do_Lcom_baidu_location_BDNotifyListener_;
		}

		static int n_Do_Lcom_baidu_location_BDNotifyListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Location.D.A __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Location.D.A> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Location.BDNotifyListener p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Location.BDNotifyListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.Do (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_do_Lcom_baidu_location_BDNotifyListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location.d']/class[@name='a']/method[@name='do' and count(parameter)=1 and parameter[1][@type='com.baidu.location.BDNotifyListener']]"
		[Register ("do", "(Lcom/baidu/location/BDNotifyListener;)I", "GetDo_Lcom_baidu_location_BDNotifyListener_Handler")]
		public virtual unsafe int Do (global::Com.Baidu.Location.BDNotifyListener p0)
		{
			if (id_do_Lcom_baidu_location_BDNotifyListener_ == IntPtr.Zero)
				id_do_Lcom_baidu_location_BDNotifyListener_ = JNIEnv.GetMethodID (class_ref, "do", "(Lcom/baidu/location/BDNotifyListener;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				int __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod  (Handle, id_do_Lcom_baidu_location_BDNotifyListener_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "do", "(Lcom/baidu/location/BDNotifyListener;)I"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_for_Lcom_baidu_location_BDNotifyListener_;
#pragma warning disable 0169
		static Delegate GetFor_Lcom_baidu_location_BDNotifyListener_Handler ()
		{
			if (cb_for_Lcom_baidu_location_BDNotifyListener_ == null)
				cb_for_Lcom_baidu_location_BDNotifyListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_For_Lcom_baidu_location_BDNotifyListener_);
			return cb_for_Lcom_baidu_location_BDNotifyListener_;
		}

		static int n_For_Lcom_baidu_location_BDNotifyListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Location.D.A __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Location.D.A> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Location.BDNotifyListener p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Location.BDNotifyListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.For (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_for_Lcom_baidu_location_BDNotifyListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location.d']/class[@name='a']/method[@name='for' and count(parameter)=1 and parameter[1][@type='com.baidu.location.BDNotifyListener']]"
		[Register ("for", "(Lcom/baidu/location/BDNotifyListener;)I", "GetFor_Lcom_baidu_location_BDNotifyListener_Handler")]
		public virtual unsafe int For (global::Com.Baidu.Location.BDNotifyListener p0)
		{
			if (id_for_Lcom_baidu_location_BDNotifyListener_ == IntPtr.Zero)
				id_for_Lcom_baidu_location_BDNotifyListener_ = JNIEnv.GetMethodID (class_ref, "for", "(Lcom/baidu/location/BDNotifyListener;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				int __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod  (Handle, id_for_Lcom_baidu_location_BDNotifyListener_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "for", "(Lcom/baidu/location/BDNotifyListener;)I"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_if_Lcom_baidu_location_BDNotifyListener_;
#pragma warning disable 0169
		static Delegate GetIf_Lcom_baidu_location_BDNotifyListener_Handler ()
		{
			if (cb_if_Lcom_baidu_location_BDNotifyListener_ == null)
				cb_if_Lcom_baidu_location_BDNotifyListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_If_Lcom_baidu_location_BDNotifyListener_);
			return cb_if_Lcom_baidu_location_BDNotifyListener_;
		}

		static void n_If_Lcom_baidu_location_BDNotifyListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Location.D.A __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Location.D.A> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Location.BDNotifyListener p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Location.BDNotifyListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.If (p0);
		}
#pragma warning restore 0169

		static IntPtr id_if_Lcom_baidu_location_BDNotifyListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location.d']/class[@name='a']/method[@name='if' and count(parameter)=1 and parameter[1][@type='com.baidu.location.BDNotifyListener']]"
		[Register ("if", "(Lcom/baidu/location/BDNotifyListener;)V", "GetIf_Lcom_baidu_location_BDNotifyListener_Handler")]
		public virtual unsafe void If (global::Com.Baidu.Location.BDNotifyListener p0)
		{
			if (id_if_Lcom_baidu_location_BDNotifyListener_ == IntPtr.Zero)
				id_if_Lcom_baidu_location_BDNotifyListener_ = JNIEnv.GetMethodID (class_ref, "if", "(Lcom/baidu/location/BDNotifyListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_if_Lcom_baidu_location_BDNotifyListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "if", "(Lcom/baidu/location/BDNotifyListener;)V"), __args);
			} finally {
			}
		}

	}
}
