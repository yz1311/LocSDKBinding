package mono.com.baidu.location;


public class GeofenceClient_OnGeofenceTriggerListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.baidu.location.GeofenceClient.OnGeofenceTriggerListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onGeofenceExit:(Ljava/lang/String;)V:GetOnGeofenceExit_Ljava_lang_String_Handler:Com.Baidu.Location.GeofenceClient/IOnGeofenceTriggerListenerInvoker, LocSDKBinding\n" +
			"n_onGeofenceTrigger:(Ljava/lang/String;)V:GetOnGeofenceTrigger_Ljava_lang_String_Handler:Com.Baidu.Location.GeofenceClient/IOnGeofenceTriggerListenerInvoker, LocSDKBinding\n" +
			"";
		mono.android.Runtime.register ("Com.Baidu.Location.GeofenceClient/IOnGeofenceTriggerListenerImplementor, LocSDKBinding, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", GeofenceClient_OnGeofenceTriggerListenerImplementor.class, __md_methods);
	}


	public GeofenceClient_OnGeofenceTriggerListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == GeofenceClient_OnGeofenceTriggerListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Baidu.Location.GeofenceClient/IOnGeofenceTriggerListenerImplementor, LocSDKBinding, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onGeofenceExit (java.lang.String p0)
	{
		n_onGeofenceExit (p0);
	}

	private native void n_onGeofenceExit (java.lang.String p0);


	public void onGeofenceTrigger (java.lang.String p0)
	{
		n_onGeofenceTrigger (p0);
	}

	private native void n_onGeofenceTrigger (java.lang.String p0);

	java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
