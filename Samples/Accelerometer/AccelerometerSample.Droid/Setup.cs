using AccelerometerSample.Core;
using Android.Content;
using MvvmCross.Core.ViewModels;
using MvvmCross.Droid.Platform;
using MvvmCross.Platform;
using MvvmCross.Plugins.Accelerometer;
using MvvmCross.Plugins.Accelerometer.Abstractions;

namespace AccelerometerSample.Droid
{
    public class Setup : MvxAndroidSetup
    {
        public Setup(Context applicationContext) 
            : base(applicationContext)
        {
        }

        protected override IMvxApplication CreateApp()
        {
            return new App();
        }

        protected override void InitializeLastChance()
        {
            base.InitializeLastChance();

            Mvx.LazyConstructAndRegisterSingleton<IMvxAccelerometer>(() => new MvxAccelerometer());
        }
    }
}