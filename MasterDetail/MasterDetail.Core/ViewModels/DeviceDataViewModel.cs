using MvvmCross.Core.ViewModels;

namespace MasterDetail.Core.ViewModels
{
    public class DeviceDataViewModel : MvxViewModel
    {
        public string Details { get; private set; }

        public DeviceDataViewModel()
        {
            Details = "These are the device data details";
        }
    }
}
