using Foundation;
using UIKit;
using System;

using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

namespace Multiplatform.iOS
{
	[Register("AppDelegate")]
	public class AppDelegate : UIApplicationDelegate
	{
		public override UIWindow Window
		{
			get;
			set;
		}

		public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
		{
			// Code to start the Xamarin Test Cloud Agent
#if DEBUG
			Xamarin.Calabash.Start();
#endif
            string appCenterID = Environment.GetEnvironmentVariable("BITRISE_APP_CENTER_ID");
            AppCenter.Start(appCenterID, typeof(Analytics), typeof(Crashes));

			return true;
		}

		public override void OnResignActivation(UIApplication application)
		{
		}

		public override void DidEnterBackground(UIApplication application)
		{
		}

		public override void WillEnterForeground(UIApplication application)
		{
		}

		public override void OnActivated(UIApplication application)
		{
		}

		public override void WillTerminate(UIApplication application)
		{
		}
	}
}

