using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;
using System.Threading.Tasks;

namespace MasterDetail.Core.ViewModels
{
    public class MainViewModel : MvxViewModel
    {
        private readonly IMvxNavigationService navigationService;

        public MainViewModel(IMvxNavigationService navigationService)
        {
            this.navigationService = navigationService;
        }

        public async Task ShowHomeAsync()
        {
            await navigationService.Navigate<HomeViewModel>();
        }
    }
}
