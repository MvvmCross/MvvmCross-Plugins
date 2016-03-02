using Android.App;
using Android.Content.PM;
using MvvmCross.Droid.Views;

namespace AccelerometerSample.Droid
{
    [Activity(
        Label = "Mvx Accelerometer"
        , MainLauncher = true
        , Icon = "@drawable/icon"
        , NoHistory = true
        , ScreenOrientation = ScreenOrientation.Portrait)]
    public class SplashScreen : MvxSplashScreenActivity
    {
        public SplashScreen() : base(Resource.Layout.splash_screen)
        {
        }
    }
}