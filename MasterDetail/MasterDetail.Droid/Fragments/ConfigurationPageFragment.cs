using Android.OS;
using Android.Runtime;
using Android.Views;
using MasterDetail.Core.ViewModels;
using MvvmCross.Binding.Droid.BindingContext;
using MvvmCross.Droid.Support.V4;
using MvvmCross.Droid.Views.Attributes;

namespace MasterDetail.Droid.Fragments
{
    [MvxFragmentPresentation(ActivityHostViewModelType = typeof(MainViewModel), FragmentContentId = Resource.Id.main_layout, AddToBackStack = true)]
    [Register(nameof(ConfigurationPageFragment))]
    public class ConfigurationPageFragment : MvxFragment<ConfigurationPageViewModel>
    {
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            base.OnCreateView(inflater, container, savedInstanceState);

            var view = this.BindingInflate(Resource.Layout.configuration_page_fragment, null);

            // Fragments contain TabLayout children!
            var fragments = Activity.SupportFragmentManager.Fragments;

            return view;
        }
    }
}