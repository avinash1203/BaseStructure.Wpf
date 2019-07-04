using Structure.UIClass;
using System.Collections.Generic;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;

namespace Structure.Views.Base
{
    /// <summary>
    /// Interaction logic for DialogWindowMain.xaml
    /// </summary>
    public partial class DialogWindowMain : Window
    {
        WindowSettings windowSettings { get; set; }

        public DialogWindowMain() => InitializeComponent();
        internal DialogWindowMain(WindowSettings windowSettings) : this()
        {
            this.windowSettings = windowSettings;
            AdjustWindowSize();
        }
        /// <summary>
        /// TitleBar_MouseDown - Drag if single-click, resize if double-click
        /// </summary>
        private void TitleBar_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                if (e.ClickCount == 2)
                {
                    AdjustWindowSize();
                }
                else
                {

                    this.DragMove();
                }
        }

        /// <summary>
        /// Adjusts the WindowSize to correct parameters when Maximize button is clicked
        /// </summary>
        private void AdjustWindowSize()
        {
            if (double.IsNaN(this.Height) || this.Height != windowSettings.NormalHeight)
            {
                this.Height = windowSettings.NormalHeight;
                this.Width = windowSettings.NormalWidth;
            }
            else
            {
                this.Height = windowSettings.MaxHeight;
                this.Width = windowSettings.MaxWidth;

            }
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            //else
            //{
            //    // this.SizeToContent = System.Windows.SizeToContent.Manual;
            //    //this.WindowState = WindowState.Maximized;

            //}

        }


        /// <summary>
        /// CloseButton_Clicked
        /// </summary>
        private void Close_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

            this.Close();

        }
        ///// <summary>
        ///// Maximize_Clicked
        ///// </summary>
        private void Maximized_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            //this.Height = 300;
            //this.Width = 300;
            AdjustWindowSize();
        }
        ///// <summary>
        ///// Minimized_Clicked
        ///// </summary>
        private void Minimized_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

            this.WindowState = WindowState.Minimized;
        }

        List<Thread> RunningThreads = new List<Thread>();
      
      




    }
    
   
}
