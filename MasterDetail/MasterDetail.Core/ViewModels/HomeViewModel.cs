using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;

namespace MasterDetail.Core.ViewModels
{
    public class HomeViewModel : MvxViewModel
    {
        public IMvxCommand SplitViewCommand { get; private set; }

        public IMvxCommand TabLayoutCommand { get; private set; }

        private readonly IMvxNavigationService navigationService;

        public HomeViewModel(IMvxNavigationService navigationService)
        {
            this.navigationService = navigationService;
            SplitViewCommand = new MvxAsyncCommand(async () => await navigationService.Navigate<ConfigurationPageViewModel>());
            TabLayoutCommand = new MvxAsyncCommand(async () => await navigationService.Navigate<TabLayoutViewModel>());
        }
    }
}
