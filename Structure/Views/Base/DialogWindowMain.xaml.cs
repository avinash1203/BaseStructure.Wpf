using System.Windows;
using System.Windows.Input;

namespace Structure.Views.Base
{
    /// <summary>
    /// Interaction logic for DialogWindowMain.xaml
    /// </summary>
    public partial class DialogWindowMain : Window
    {
        public DialogWindowMain()
        {
            InitializeComponent();

         
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
            if (this.WindowState == WindowState.Maximized)
            {
                this.WindowState = WindowState.Normal;

            }
            else
            {
                this.SizeToContent = System.Windows.SizeToContent.Manual;
                this.WindowState = WindowState.Maximized;

            }

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
            AdjustWindowSize();
        }
        ///// <summary>
        ///// Minimized_Clicked
        ///// </summary>
        private void Minimized_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
         
            this.WindowState = WindowState.Minimized;
        }

       
    }
}
