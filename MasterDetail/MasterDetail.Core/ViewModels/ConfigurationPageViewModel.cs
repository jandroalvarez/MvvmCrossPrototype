using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;

namespace MasterDetail.Core.ViewModels
{
    public class ConfigurationPageViewModel : MvxViewModel
    {
        public IMvxCommand ShowCharateristicsDetailsCommand { get; private set; }

        public IMvxCommand ShowDeviceDataDetailsCommand { get; private set; }

        public IMvxCommand ShowSignalizationCommand { get; private set; }

        private readonly IMvxNavigationService navigationService;

        public ConfigurationPageViewModel(IMvxNavigationService navigationService)
        {
            this.navigationService = navigationService;
            ShowCharateristicsDetailsCommand = new MvxAsyncCommand(async () => await navigationService.Navigate<CharacteristicsViewModel>());
            ShowDeviceDataDetailsCommand = new MvxAsyncCommand(async () => await navigationService.Navigate<DeviceDataViewModel>());
            ShowSignalizationCommand = new MvxAsyncCommand(async () => await navigationService.Navigate<TabLayoutViewModel>());
        }
    }
}
