using Android.OS;
using Android.Runtime;
using Android.Views;
using MasterDetail.Core.ViewModels;
using MvvmCross.Binding.Droid.BindingContext;
using MvvmCross.Droid.Support.V4;
using MvvmCross.Droid.Views.Attributes;

namespace MasterDetail.Droid.Fragments
{
    [MvxFragmentPresentation(typeof(MainViewModel), Resource.Id.main_layout)]
    [Register(nameof(HomeFragment))]
    public class HomeFragment : MvxFragment<HomeViewModel>
    {
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            base.OnCreateView(inflater, container, savedInstanceState);

            return this.BindingInflate(Resource.Layout.home_fragment, null);
        }
    }
}