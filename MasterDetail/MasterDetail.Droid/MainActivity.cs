using Android.App;
using Android.Content.PM;
using Android.OS;
using MasterDetail.Core.ViewModels;
using MvvmCross.Droid.Support.V7.AppCompat;

namespace MasterDetail.Droid
{
    [Activity(Label = "MasterDetail.Droid", Theme = "@style/AppTheme", LaunchMode = LaunchMode.SingleTask, MainLauncher = true)]
    public class MainActivity : MvxAppCompatActivity<MainViewModel>
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            ViewModel.ShowHomeAsync();
        }
    }
}

