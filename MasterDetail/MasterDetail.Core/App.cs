using MasterDetail.Core.ViewModels;
using MvvmCross.Core.ViewModels;

namespace MasterDetail.Core
{
    public class App : MvxApplication
    {

        public override void Initialize()
        {
            RegisterNavigationServiceAppStart<MainViewModel>();
        }
    }
}