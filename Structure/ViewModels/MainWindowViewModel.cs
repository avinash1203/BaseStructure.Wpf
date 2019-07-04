using Structure.Base.AbstractClass;
using Structure.Commands;
using Structure.UIClass;
using Structure.Views;
using Structure.Views.Base;
using System.Windows;
using System.Windows.Input;


namespace Structure.ViewModels
{
    class MainWindowViewModel : BaseViewModel
    {
        #region Commands
        public ICommand ShowDialogWindowCommand { get; set; }

        public ICommand ChangeThemeCommand { get; set; }

        public ICommand ChangeLangugeCommand { get; set; }
        public ICommand ExitCommand { get; set; }

        #endregion

        internal MainWindowViewModel()
        {


            ShowDialogWindowCommand = new RelayCommand(ShowDialogWindow);
            ChangeThemeCommand = new RelayCommand(ChangeTheme);
            ChangeLangugeCommand = new RelayCommand(ChangeLanguge);
            ExitCommand = new RelayCommand(Exit);
        }


        #region Methods

        private void Exit(object obj)
        {

        }
        /// <summary>
        /// ChangeTheme
        /// </summary>
        /// <param name="obj"></param>
        private void ChangeTheme(object obj)
        {
            var app = (App)Application.Current;
            app.ChangeTheme();
        }
        /// <summary>
        /// ChangeLanguge
        /// </summary>
        /// <param name="obj"></param>
        private void ChangeLanguge(object obj)
        {
            var app = (App)Application.Current;
            app.ChangeLanguage();
        }

        /// <summary>
        /// Show  Dialog Window
        /// </summary>
        /// <param name="obj"></param>
        private void ShowDialogWindow(object obj)
        {
            //DialogWindowView dialogWindowView = new DialogWindowView();
            //SelectReportView selectReportView = new SelectReportView();
            //SelectReportViewModel selectReportViewModel = new SelectReportViewModel(true);
            //selectReportViewModel.Content = selectReportView;
            //dialogWindowView.DataContext = selectReportViewModel;
            //selectReportView.DataContext = selectReportViewModel;
            //selectReportViewModel.RequetClose += (s, sa) => dialogWindowView.Close();
            //dialogWindowView.ShowDialog();

            DialogWindowMain dialogWindowMain = new DialogWindowMain(new WindowSettings { MaxHeight = 650, MaxWidth = 600, NormalHeight = 650, NormalWidth = 530 });
            dialogWindowMain.ContentGrid.Children.Add(new SpecificationView());
            dialogWindowMain.ShowDialog();

        }

        #endregion


    }
}
