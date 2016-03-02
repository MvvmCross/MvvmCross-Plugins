using AccelerometerSample.Core.ViewModels;
using Android.App;
using Android.OS;
using MvvmCross.Droid.Views;

namespace AccelerometerSample.Droid.Views
{
    [Activity]
    public class FirstActivity 
        : MvxActivity<FirstViewModel>
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.first_view);
        }
    }
}