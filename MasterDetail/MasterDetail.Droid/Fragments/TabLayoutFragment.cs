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
    [MvxFragmentPresentation(FragmentHostViewType = typeof(ConfigurationPageFragment), FragmentContentId = Resource.Id.config_detail_layout)]
    [Register(nameof(TabLayoutFragment))]
    public class TabLayoutFragment : MvxFragment<TabLayoutViewModel>
    {
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            base.OnCreateView(inflater, container, savedInstanceState);

            var view = this.BindingInflate(Resource.Layout.tab_layout_fragment, null);

            return view;
        }

        public override void OnViewCreated(View view, Bundle savedInstanceState)
        {
            ViewModel.ShowInitialViewModelsCommand.Execute();
        }
    }
}