using Structure.ViewModels;
using Structure.Views;
using Structure.Views.Base;
using System.Windows;

namespace Structure
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindowView : Window
    {
        public MainWindowView()
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel();
        }

    }
}
