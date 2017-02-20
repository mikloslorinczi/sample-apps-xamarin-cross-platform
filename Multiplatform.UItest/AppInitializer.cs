using System;
using Xamarin.UITest;
using Xamarin.UITest.Configuration;

namespace Multiplatform.UItest
{
	public class AppInitializer
	{
		public static IApp StartApp(Platform platform)
		{
			if (platform == Platform.Android)
			{
				AndroidAppConfigurator androidConfigurator = ConfigureApp.Android;

				string apkPath = Environment.GetEnvironmentVariable("ANDROID_APK_PATH");
				if (!string.IsNullOrEmpty(apkPath))
				{
					androidConfigurator.ApkFile(apkPath);
				}

				string emulatorSerial = Environment.GetEnvironmentVariable("BITRISE_EMULATOR_SERIAL");
				if (!string.IsNullOrEmpty(emulatorSerial))
				{
					androidConfigurator.DeviceSerial(emulatorSerial);
				}

				return androidConfigurator.StartApp();
			}

			iOSAppConfigurator iosConfigurator = ConfigureApp.iOS;

			string appBundlePath = Environment.GetEnvironmentVariable("APP_BUNDLE_PATH");
			if (!string.IsNullOrEmpty(appBundlePath))
			{
				iosConfigurator.AppBundle(appBundlePath);
			}

			string simulatorUDID = Environment.GetEnvironmentVariable("IOS_SIMULATOR_UDID");
			if (!string.IsNullOrEmpty(simulatorUDID))
			{
				iosConfigurator.DeviceIdentifier(simulatorUDID);
			}

			return iosConfigurator.StartApp();
		}
	}
}
