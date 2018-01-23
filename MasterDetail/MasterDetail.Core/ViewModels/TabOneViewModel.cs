using MvvmCross.Core.ViewModels;

namespace MasterDetail.Core.ViewModels
{
    public class TabOneViewModel : MvxViewModel
    {
        public string Details { get; private set; }

        public TabOneViewModel()
        {
            Details = "This is the tab one";
        }
    }
}
