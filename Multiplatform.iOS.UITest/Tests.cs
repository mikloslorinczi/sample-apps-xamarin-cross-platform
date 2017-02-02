using System;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.iOS;

namespace Multiplatform.iOS.UITest
{
	[TestFixture]
	public class Tests
	{
		iOSApp app;

		[SetUp]
		public void BeforeEachTest()
		{
			string appBundlePath = Environment.GetEnvironmentVariable("APP_BUNDLE_PATH");

			if (!string.IsNullOrEmpty(appBundlePath))
			{
				// In case of Bitrise step: steps-xamarin-ios-uitest.
				app = ConfigureApp
					.iOS
					.AppBundle(appBundlePath)
					.StartApp();
			}
			else {
				// In case of Bitrise step: steps-xamarin-testcloud-for-ios or running in the IDE.
				app = ConfigureApp
					.iOS
					.StartApp();
			}
		}

		[Test]
		public void AppLaunches()
		{
			app.Screenshot("First screen.");
		}
	}
}
