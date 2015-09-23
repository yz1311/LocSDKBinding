using System;
using Android.App;
using Com.Baidu.Location;
using Android.Widget;
using Android.OS;
using System.Text;
using Android.Util;
using Android.Runtime;
using Android.Content;

namespace LocSDKBindingDemo
{
	[Application]
	public class LocationApplication : Application
	{
		public LocationClient mLocationClient;
		public MyLocationListener mMyLocationListener;

		public  TextView mLocationResult,logMsg;
		public TextView trigger,exit;
		public Vibrator mVibrator;
		Handler handler=null;

		public LocationApplication(IntPtr handle, JniHandleOwnership ownerShip) : base(handle,ownerShip)
		{
			handler = new Handler ();
		}


		public override void OnCreate ()
		{
			base.OnCreate ();
			mLocationClient = new LocationClient(ApplicationContext);
			var option = new LocationClientOption ();
			option.SetIsNeedAddress (true);
			option.SetIsNeedLocationDescribe (true);
			mLocationClient.LocOption = option;
			mMyLocationListener = new MyLocationListener(handler, this);
			mLocationClient.RegisterLocationListener(mMyLocationListener);
	

			mVibrator =(Vibrator)ApplicationContext.GetSystemService(Service.VibratorService);

		}

		/**
	 * 实现实位回调监听
	 */
		public class MyLocationListener :Java.Lang.Object, IBDLocationListener {
			private Handler mHandlder;
			private Context mContext;
			private TextView textView;

			public MyLocationListener(Handler handler, Context context)
			{
				mContext=context;
				mHandlder=handler;
			}
				

			#region IBDLocationListener implementation
			public void OnReceiveLocation (BDLocation location)
			{
				//Receive Location 
				StringBuilder sb = new StringBuilder(256);
				sb.Append("time : ");
				sb.Append(location.Time);
				sb.Append("\nerror code : ");
				sb.Append(location.LocType);
				sb.Append("\nlatitude : ");
				sb.Append(location.Latitude);
				sb.Append("\nlontitude : ");
				sb.Append(location.Longitude);
				sb.Append("\nradius : ");
				sb.Append(location.Radius);
				sb.Append ("\n"+location.Country+" "+location.City+" "+location.Street+" "+location.AddrStr+" \n");
				if (location.LocType== BDLocation.TypeGpsLocation){
					sb.Append("\nspeed : ");
					sb.Append(location.Speed);
					sb.Append("\nsatellite : ");
					sb.Append(location.SatelliteNumber);
					sb.Append("\ndirection : ");
					sb.Append("\naddr : ");
					sb.Append(location.AddrStr);
					sb.Append(location.Direction);
				} else if (location.LocType == BDLocation.TypeNetWorkLocation){
					sb.Append("\naddr : ");
					sb.Append(location.AddrStr);
					//运营商信息
					sb.Append("\noperationers : ");
					sb.Append(location.Operators);
				}
				//LogMsg(sb.ToString());
				mHandlder.Post(()=>{
					//textView.Text = sb.ToString ();
					Toast.MakeText(mContext,sb.ToString(),ToastLength.Long).Show();
				});

				Log.Info("BaiduLocationApiDem", sb.ToString());
			}
			#endregion

		}


		/**
	 * 显示请求字符串
	 * @param str
	 */
	
	}
}

