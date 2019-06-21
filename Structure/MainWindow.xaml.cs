using Structure.ViewModels;
using Structure.Views;
using Structure.Views.Base;
using System.Windows;

namespace Structure
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {


            DialogWindowView dialogWindowView = new DialogWindowView();
            SelectReportView selectReportView = new SelectReportView();
            SelectReportViewModel selectReportViewModel = new SelectReportViewModel(true);
            selectReportViewModel.Content = selectReportView;
            dialogWindowView.DataContext = selectReportViewModel;
            selectReportView.DataContext = selectReportViewModel;
            selectReportViewModel.RequetClose += (s, sa) => dialogWindowView.Close();
            dialogWindowView.ShowDialog();
        }
    }
}
