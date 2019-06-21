using Structure.Base.AbstractClass;
using Structure.Base.Interfaces;
using Structure.Commands;
using System;
using System.Windows;
using System.Windows.Input;

namespace Structure.ViewModels.Base
{

    class DialogWindowViewModel : BaseViewModel, IWindowSettings
    {


        #region Events
        public event EventHandler RequetClose;

        #endregion


        #region Icommand

        public ICommand CloseCommand { get; set; }

        //public ICommand HeaderMouseDown { get; set; }

        public ActionCommand<MouseButtonEventArgs, object> HeaderMouseDown { get; private set; }



        #endregion

        #region prop



        private object content;

        public object Content
        {
            get { return content; }
            set { content = value; OnPropertyRaised("Content"); }
        }

        private SizeToContent windowsizeToContent;

        public SizeToContent WindowSizeToContent
        {
            get { return windowsizeToContent; }
            set { windowsizeToContent = value; OnPropertyRaised("WindowSizeToContent"); }
        }


        private ResizeMode windowresizeMode;

        public ResizeMode WindowReSizeMode
        {
            get { return windowresizeMode; }
            set { windowresizeMode = value; OnPropertyRaised("WindowReSizeMode"); }
        }
        private WindowState windowState;

        public WindowState WindowsState
        {
            get { return windowState; }
            set { windowState = value; OnPropertyRaised("WindowsState"); }
        }


        #endregion

        #region Ctro

        internal DialogWindowViewModel()
        {
            CloseCommand = new RelayCommand(Close);
            HeaderMouseDown = new ActionCommand<MouseButtonEventArgs, object>(TitleBar_MouseDown);
        }

        internal DialogWindowViewModel(bool openAsDialog) : this()
        {

            this.WindowReSizeMode = ResizeMode.NoResize;
            this.WindowSizeToContent = SizeToContent.WidthAndHeight;
        }




        #endregion

        #region Methods

        /// <summary>
        /// TitleBar_MouseDown - Drag if single-click, resize if double-click
        /// </summary>
        private void TitleBar_MouseDown(MouseButtonEventArgs e, object CmbParameter)
        {
            if (e.ChangedButton == MouseButton.Left)
                Application.Current.MainWindow.DragMove();


            //if (e.ClickCount == 2)
            //    {
            //        AdjustWindowSize();
            //    }
            //    else
            //    {

                   
            //    }
        }
        /// <summary>
        /// Adjusts the WindowSize to correct parameters when Maximize button is clicked
        /// </summary>
        private void AdjustWindowSize()
        {
            if (WindowsState == WindowState.Maximized)
            {
                WindowsState = WindowState.Normal;
                // MaxButton.Content = "1";
            }
            else
            {
                WindowsState = WindowState.Maximized;
                //MaxButton.Content = "2";
            }

        }

        /// <summary>
        /// To Close the Window
        /// </summary>
        /// <param name="obj"></param>
        private void Close(object obj)
        {
            RequetClose(null, null);
        }
        #endregion

    }
}
