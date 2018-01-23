using MvvmCross.Core.ViewModels;

namespace MasterDetail.Core.ViewModels
{
    public class TabTwoViewModel : MvxViewModel
    {
        public string Details { get; private set; }

        public TabTwoViewModel()
        {
            Details = "This is the tab two";
        }
    }
}
