using MvvmCross.Core.ViewModels;

namespace MasterDetail.Core.ViewModels
{
    public class CharacteristicsViewModel : MvxViewModel
    {
        public string Details { get; private set; }

        public CharacteristicsViewModel()
        {
            Details = "These are the characteristics details";
        }
    }
}
