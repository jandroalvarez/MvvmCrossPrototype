using Android.OS;
using Android.Runtime;
using Android.Views;
using MasterDetail.Core.ViewModels;
using MvvmCross.Binding.Droid.BindingContext;
using MvvmCross.Droid.Support.V4;
using MvvmCross.Droid.Views.Attributes;

namespace MasterDetail.Droid.Fragments
{
    [MvxTabLayoutPresentation(TabLayoutResourceId = Resource.Id.tabs, ViewPagerResourceId = Resource.Id.viewpager, Title = "Tab 1")]
    [Register(nameof(TabOneFragment))]
    public class TabOneFragment : MvxFragment<TabOneViewModel>
    {
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            base.OnCreateView(inflater, container, savedInstanceState);

            return this.BindingInflate(Resource.Layout.tab_one_fragment, null);
        }
    }
}