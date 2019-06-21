using Structure.Base.Interfaces;
using Structure.ViewModels.Base;
using System.Windows;

namespace Structure.ViewModels
{
    class SelectReportViewModel : DialogWindowViewModel
    {
        internal SelectReportViewModel()
        {

        }
        internal SelectReportViewModel(bool openAsDialog):base(openAsDialog)
        {

        }
    }
}
