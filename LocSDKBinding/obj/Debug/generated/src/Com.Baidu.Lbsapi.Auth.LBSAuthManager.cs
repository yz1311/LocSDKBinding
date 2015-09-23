using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Baidu.Lbsapi.Auth {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.lbsapi.auth']/class[@name='LBSAuthManager']"
	[global::Android.Runtime.Register ("com/baidu/lbsapi/auth/LBSAuthManager", DoNotGenerateAcw=true)]
	public partial class LBSAuthManager : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.lbsapi.auth']/class[@name='LBSAuthManager']/field[@name='AUTH_URL']"
		[Register ("AUTH_URL")]
		protected const string AuthUrl = (string) "https://sapi.map.baidu.com/sdkcs/verify";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.lbsapi.auth']/class[@name='LBSAuthManager']/field[@name='CODE_AUTHENTICATE_SUCC']"
		[Register ("CODE_AUTHENTICATE_SUCC")]
		public const int CodeAuthenticateSucc = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.lbsapi.auth']/class[@name='LBSAuthManager']/field[@name='CODE_AUTHENTICATING']"
		[Register ("CODE_AUTHENTICATING")]
		public const int CodeAuthenticating = (int) 602;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.lbsapi.auth']/class[@name='LBSAuthManager']/field[@name='CODE_INNER_ERROR']"
		[Register ("CODE_INNER_ERROR")]
		protected const int CodeInnerError = (int) -1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.lbsapi.auth']/class[@name='LBSAuthManager']/field[@name='CODE_UNAUTHENTICATE']"
		[Register ("CODE_UNAUTHENTICATE")]
		public const int CodeUnauthenticate = (int) 601;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.lbsapi.auth']/class[@name='LBSAuthManager']/field[@name='VERSION']"
		[Register ("VERSION")]
		public const string Version = (string) "1.0.4";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/baidu/lbsapi/auth/LBSAuthManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LBSAuthManager); }
		}

		protected LBSAuthManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.lbsapi.auth']/class[@name='LBSAuthManager']/constructor[@name='LBSAuthManager' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe LBSAuthManager (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (LBSAuthManager)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static Delegate cb_authenticate_ZLjava_lang_String_Ljava_util_Hashtable_Lcom_baidu_lbsapi_auth_LBSAuthManagerListener_;
#pragma warning disable 0169
		static Delegate GetAuthenticate_ZLjava_lang_String_Ljava_util_Hashtable_Lcom_baidu_lbsapi_auth_LBSAuthManagerListener_Handler ()
		{
			if (cb_authenticate_ZLjava_lang_String_Ljava_util_Hashtable_Lcom_baidu_lbsapi_auth_LBSAuthManagerListener_ == null)
				cb_authenticate_ZLjava_lang_String_Ljava_util_Hashtable_Lcom_baidu_lbsapi_auth_LBSAuthManagerListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr, IntPtr, IntPtr, int>) n_Authenticate_ZLjava_lang_String_Ljava_util_Hashtable_Lcom_baidu_lbsapi_auth_LBSAuthManagerListener_);
			return cb_authenticate_ZLjava_lang_String_Ljava_util_Hashtable_Lcom_baidu_lbsapi_auth_LBSAuthManagerListener_;
		}

		static int n_Authenticate_ZLjava_lang_String_Ljava_util_Hashtable_Lcom_baidu_lbsapi_auth_LBSAuthManagerListener_ (IntPtr jnienv, IntPtr native__this, bool p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Baidu.Lbsapi.Auth.LBSAuthManager __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Lbsapi.Auth.LBSAuthManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Hashtable p2 = global::Java.Lang.Object.GetObject<global::Java.Util.Hashtable> (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Lbsapi.Auth.ILBSAuthManagerListener p3 = (global::Com.Baidu.Lbsapi.Auth.ILBSAuthManagerListener)global::Java.Lang.Object.GetObject<global::Com.Baidu.Lbsapi.Auth.ILBSAuthManagerListener> (native_p3, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.Authenticate (p0, p1, p2, p3);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_authenticate_ZLjava_lang_String_Ljava_util_Hashtable_Lcom_baidu_lbsapi_auth_LBSAuthManagerListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.lbsapi.auth']/class[@name='LBSAuthManager']/method[@name='authenticate' and count(parameter)=4 and parameter[1][@type='boolean'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.util.Hashtable&lt;java.lang.String, java.lang.String&gt;'] and parameter[4][@type='com.baidu.lbsapi.auth.LBSAuthManagerListener']]"
		[Register ("authenticate", "(ZLjava/lang/String;Ljava/util/Hashtable;Lcom/baidu/lbsapi/auth/LBSAuthManagerListener;)I", "GetAuthenticate_ZLjava_lang_String_Ljava_util_Hashtable_Lcom_baidu_lbsapi_auth_LBSAuthManagerListener_Handler")]
		public virtual unsafe int Authenticate (bool p0, string p1, global::Java.Util.Hashtable p2, global::Com.Baidu.Lbsapi.Auth.ILBSAuthManagerListener p3)
		{
			if (id_authenticate_ZLjava_lang_String_Ljava_util_Hashtable_Lcom_baidu_lbsapi_auth_LBSAuthManagerListener_ == IntPtr.Zero)
				id_authenticate_ZLjava_lang_String_Ljava_util_Hashtable_Lcom_baidu_lbsapi_auth_LBSAuthManagerListener_ = JNIEnv.GetMethodID (class_ref, "authenticate", "(ZLjava/lang/String;Ljava/util/Hashtable;Lcom/baidu/lbsapi/auth/LBSAuthManagerListener;)I");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				int __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod  (Handle, id_authenticate_ZLjava_lang_String_Ljava_util_Hashtable_Lcom_baidu_lbsapi_auth_LBSAuthManagerListener_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "authenticate", "(ZLjava/lang/String;Ljava/util/Hashtable;Lcom/baidu/lbsapi/auth/LBSAuthManagerListener;)I"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_getPublicKey_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetGetPublicKey_Landroid_content_Context_Handler ()
		{
			if (cb_getPublicKey_Landroid_content_Context_ == null)
				cb_getPublicKey_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetPublicKey_Landroid_content_Context_);
			return cb_getPublicKey_Landroid_content_Context_;
		}

		static IntPtr n_GetPublicKey_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Lbsapi.Auth.LBSAuthManager __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Lbsapi.Auth.LBSAuthManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetPublicKey (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getPublicKey_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.lbsapi.auth']/class[@name='LBSAuthManager']/method[@name='getPublicKey' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getPublicKey", "(Landroid/content/Context;)Ljava/lang/String;", "GetGetPublicKey_Landroid_content_Context_Handler")]
		public virtual unsafe string GetPublicKey (global::Android.Content.Context p0)
		{
			if (id_getPublicKey_Landroid_content_Context_ == IntPtr.Zero)
				id_getPublicKey_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "getPublicKey", "(Landroid/content/Context;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				string __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getPublicKey_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPublicKey", "(Landroid/content/Context;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
