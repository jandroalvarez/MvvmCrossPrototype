using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MasterDetail.Core.ViewModels
{
    public class TabLayoutViewModel : MvxViewModel
    {
        private readonly IMvxNavigationService navigationService;

        public IMvxAsyncCommand ShowInitialViewModelsCommand { get; private set; }

        public TabLayoutViewModel(IMvxNavigationService navigationService)
        {
            this.navigationService = navigationService;
            ShowInitialViewModelsCommand = new MvxAsyncCommand(ShowInitialViewModelsAsync);
        }

        private async Task ShowInitialViewModelsAsync()
        {
            var tasks = new List<Task>();
            tasks.Add(navigationService.Navigate<TabOneViewModel>());
            tasks.Add(navigationService.Navigate<TabTwoViewModel>());
            await Task.WhenAll(tasks);
        }
    }
}
