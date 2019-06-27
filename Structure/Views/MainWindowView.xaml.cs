using Structure.Base.AbstractClass;
using Structure.ViewModels;
using Structure.Views;
using Structure.Views.Base;
using System;
using System.Collections.Generic;
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

            //drg.ItemsSource = new List<MyViewModel> { new MyViewModel { Date = null }, new MyViewModel { Date = DateTime.Now } };

        }

    }

    //internal class MyViewModel : BaseViewModel
    //{
        

    //    private DateTime? _date;
    //    public DateTime? Date
    //    {
    //        get => _date;
    //        set { _date = value; OnPropertyRaised("Date"); }
    //    }
    //}

}
