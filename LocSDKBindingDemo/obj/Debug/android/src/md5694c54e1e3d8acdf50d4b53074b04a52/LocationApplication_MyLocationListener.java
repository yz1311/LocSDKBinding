package md5694c54e1e3d8acdf50d4b53074b04a52;


public class LocationApplication_MyLocationListener
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.baidu.location.BDLocationListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onReceiveLocation:(Lcom/baidu/location/BDLocation;)V:GetOnReceiveLocation_Lcom_baidu_location_BDLocation_Handler:Com.Baidu.Location.IBDLocationListenerInvoker, LocSDKBinding\n" +
			"";
		mono.android.Runtime.register ("LocSDKBindingDemo.LocationApplication/MyLocationListener, LocSDKBindingDemo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", LocationApplication_MyLocationListener.class, __md_methods);
	}


	public LocationApplication_MyLocationListener () throws java.lang.Throwable
	{
		super ();
		if (getClass () == LocationApplication_MyLocationListener.class)
			mono.android.TypeManager.Activate ("LocSDKBindingDemo.LocationApplication/MyLocationListener, LocSDKBindingDemo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

	public LocationApplication_MyLocationListener (android.os.Handler p0, android.content.Context p1) throws java.lang.Throwable
	{
		super ();
		if (getClass () == LocationApplication_MyLocationListener.class)
			mono.android.TypeManager.Activate ("LocSDKBindingDemo.LocationApplication/MyLocationListener, LocSDKBindingDemo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.OS.Handler, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0, p1 });
	}


	public void onReceiveLocation (com.baidu.location.BDLocation p0)
	{
		n_onReceiveLocation (p0);
	}

	private native void n_onReceiveLocation (com.baidu.location.BDLocation p0);

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
