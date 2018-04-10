using Android.App;
using Android.Widget;
using Android.OS;

using System;

using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

namespace Multiplatform.Droid
{
	[Activity(Label = "Multiplatform", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
		int count = 1;

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

            string appCenterID = System.Environment.GetEnvironmentVariable("BITRISE_APP_CENTER_ID");
            AppCenter.Start(appCenterID, typeof(Analytics), typeof(Crashes));

			SetContentView(Resource.Layout.Main);

			Button button = FindViewById<Button>(Resource.Id.myButton);
			button.Click += delegate { button.Text = string.Format("{0} clicks!", count++); };
		}
	}
}

