package mono.com.baidu.location;


public class GeofenceClient_OnRemoveBDGeofencesResultListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.baidu.location.GeofenceClient.OnRemoveBDGeofencesResultListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onRemoveBDGeofencesByRequestIdsResult:(I[Ljava/lang/String;)V:GetOnRemoveBDGeofencesByRequestIdsResult_IarrayLjava_lang_String_Handler:Com.Baidu.Location.GeofenceClient/IOnRemoveBDGeofencesResultListenerInvoker, LocSDKBinding\n" +
			"";
		mono.android.Runtime.register ("Com.Baidu.Location.GeofenceClient/IOnRemoveBDGeofencesResultListenerImplementor, LocSDKBinding, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", GeofenceClient_OnRemoveBDGeofencesResultListenerImplementor.class, __md_methods);
	}


	public GeofenceClient_OnRemoveBDGeofencesResultListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == GeofenceClient_OnRemoveBDGeofencesResultListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Baidu.Location.GeofenceClient/IOnRemoveBDGeofencesResultListenerImplementor, LocSDKBinding, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onRemoveBDGeofencesByRequestIdsResult (int p0, java.lang.String[] p1)
	{
		n_onRemoveBDGeofencesByRequestIdsResult (p0, p1);
	}

	private native void n_onRemoveBDGeofencesByRequestIdsResult (int p0, java.lang.String[] p1);

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
