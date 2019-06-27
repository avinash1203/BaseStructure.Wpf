
using Structure.UIClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Structure.Views
{
    /// <summary>
    /// Interaction logic for SpecificationView.xaml
    /// </summary>
    public partial class SpecificationView : UserControl
    {
        public SpecificationView()
        {
            List<CheckableItem> checkableItems = new List<CheckableItem>();
            checkableItems.Add(new CheckableItem { Value = "1", IsChecked = !false, Children = new List<CheckableItem> { new CheckableItem { Value = "1", IsChecked = !false }, new CheckableItem { Value = "2", IsChecked = !false }, new CheckableItem { Value = "3", IsChecked = !false } } });
            checkableItems.Add(new CheckableItem { Value = "1", IsChecked = !false, Children = new List<CheckableItem> { new CheckableItem { Value = "1", IsChecked = !false }, new CheckableItem { Value = "2", IsChecked = !false }, new CheckableItem { Value = "3", IsChecked = !false } } });
            checkableItems.Add(new CheckableItem { Value = "1", IsChecked = !false, Children = new List<CheckableItem> { new CheckableItem { Value = "1", IsChecked = !false }, new CheckableItem { Value = "2", IsChecked = !false }, new CheckableItem { Value = "3", IsChecked = !false } } });
            InitializeComponent();
            tree.ItemsSource = checkableItems;
        }
    }
}
