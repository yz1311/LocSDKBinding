package mono.com.baidu.location;


public class GeofenceClient_OnAddBDGeofencesResultListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.baidu.location.GeofenceClient.OnAddBDGeofencesResultListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onAddBDGeofencesResult:(ILjava/lang/String;)V:GetOnAddBDGeofencesResult_ILjava_lang_String_Handler:Com.Baidu.Location.GeofenceClient/IOnAddBDGeofencesResultListenerInvoker, LocSDKBinding\n" +
			"";
		mono.android.Runtime.register ("Com.Baidu.Location.GeofenceClient/IOnAddBDGeofencesResultListenerImplementor, LocSDKBinding, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", GeofenceClient_OnAddBDGeofencesResultListenerImplementor.class, __md_methods);
	}


	public GeofenceClient_OnAddBDGeofencesResultListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == GeofenceClient_OnAddBDGeofencesResultListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Baidu.Location.GeofenceClient/IOnAddBDGeofencesResultListenerImplementor, LocSDKBinding, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onAddBDGeofencesResult (int p0, java.lang.String p1)
	{
		n_onAddBDGeofencesResult (p0, p1);
	}

	private native void n_onAddBDGeofencesResult (int p0, java.lang.String p1);

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
