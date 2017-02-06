using System;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.iOS;
using Xamarin.UITest.Configuration;

namespace Multiplatform.iOS.UITest
{
	[TestFixture]
	public class Tests
	{
		iOSApp app;

		[SetUp]
		public void BeforeEachTest()
		{
			iOSAppConfigurator configurator = ConfigureApp.iOS;

			string appBundlePath = Environment.GetEnvironmentVariable("APP_BUNDLE_PATH");
			if (!string.IsNullOrEmpty(appBundlePath))
			{
				configurator.AppBundle(appBundlePath);
			}

			string simulatorUDID = Environment.GetEnvironmentVariable("IOS_SIMULATOR_UDID");
			if (!string.IsNullOrEmpty(simulatorUDID))
			{
				configurator.DeviceIdentifier(simulatorUDID);
			}

			app = configurator.StartApp();
		}

		[Test]
		public void AppLaunches()
		{
			app.Screenshot("First screen.");
		}
	}
}
