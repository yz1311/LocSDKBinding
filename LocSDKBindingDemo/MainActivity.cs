using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Com.Baidu.Location;

namespace LocSDKBindingDemo
{
	[Activity (Label = "LocSDKBindingDemo", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity ,Android.Widget.RadioGroup.IOnCheckedChangeListener
	{
		int count = 1;
		private LocationClient mLocationClient;
		private TextView LocationResult,ModeInfor;
		private Button startLocation;
		private RadioGroup selectMode,selectCoordinates;
		private EditText frequence;
		private LocationClientOption.LocationMode tempMode = LocationClientOption.LocationMode.HightAccuracy;
		private String tempcoor="gcj02";
		private CheckBox checkGeoLocation;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);
			mLocationClient = ((LocationApplication)Application).mLocationClient;

		
			LocationResult = (TextView)FindViewById(Resource.Id.textView1);
			ModeInfor= (TextView)FindViewById(Resource.Id.modeinfor);
			ModeInfor.Text=Resources.GetString(Resource.String.hight_accuracy_desc);
			((LocationApplication)Application).mLocationResult = LocationResult;
			frequence = (EditText)FindViewById(Resource.Id.frequence);
			checkGeoLocation = (CheckBox)FindViewById(Resource.Id.geolocation);
			startLocation = (Button)FindViewById(Resource.Id.addfence);

			startLocation.Click += StartLocation_Clicked;

			selectMode = (RadioGroup)FindViewById(Resource.Id.selectMode);
			selectCoordinates= (RadioGroup)FindViewById(Resource.Id.selectCoordinates);
			selectMode.SetOnCheckedChangeListener (this);
			selectCoordinates.CheckedChange+= Select_CheckedChanged ;
		}

		public void OnCheckedChanged (RadioGroup group, int checkedId)
		{
			String ModeInformation = null;
			switch (checkedId) {
			case Resource.Id.radio_hight:
				tempMode = LocationClientOption.LocationMode.HightAccuracy;
				ModeInformation = Resources.GetString(Resource.String.hight_accuracy_desc);
				break;
			case Resource.Id.radio_low:
				tempMode = LocationClientOption.LocationMode.BatterySaving;
				ModeInformation = Resources.GetString(Resource.String.saving_battery_desc);
				break;
			case Resource.Id.radio_device:
				tempMode = LocationClientOption.LocationMode.DeviceSensors;
				ModeInformation = Resources.GetString(Resource.String.device_sensor_desc);
				break;
			default:
				break;
			}
			ModeInfor.Text=ModeInformation;
		}

		void Select_CheckedChanged(object sender, RadioGroup.CheckedChangeEventArgs e)
		{
			switch (e.CheckedId) {
			case Resource.Id.radio_gcj02:
					tempcoor="gcj02";
					break;
			case Resource.Id.radio_bd09ll:
					tempcoor="bd09ll";
					break;
			case Resource.Id.radio_bd09:
					tempcoor="bd09";
					break;
				default:
					break;
			}

		}

		void StartLocation_Clicked(object sender, EventArgs e)
		{
			InitLocation();

			if(startLocation.Text.Equals(Resources.GetString(Resource.String.startlocation))){
				mLocationClient.Start ();
				startLocation.Text=Resources.GetString(Resource.String.stoplocation);
			}else{
				mLocationClient.Stop ();
				startLocation.Text=Resources.GetString(Resource.String.startlocation);
			}
		}

		private void InitLocation(){
			LocationClientOption option = new LocationClientOption();
			option.SetLocationMode(tempMode);//设置定位模式
			option.CoorType=tempcoor;//返回的定位结果是百度经纬度，默认值gcj02
			int span=1000;
			try {
				span =int.Parse(frequence.Text.ToString());
			} catch (Exception e) {
				// TODO: handle exception
			}
			option.ScanSpan=span;//设置发起定位请求的间隔时间为5000ms
			option.SetIsNeedAddress(checkGeoLocation.Checked);
			mLocationClient.LocOption=option;
		}

		protected override void OnStop() {
			mLocationClient.Stop();
			base.OnStop ();
		}

	}
}


