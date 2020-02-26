using Diplom.Pages;
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

namespace Diplom
{
    /// <summary>
    /// Interaction logic for UserControlMenuItem.xaml
    /// </summary>
    public partial class UserControlMenuItem : UserControl
    {
        public UserControlMenuItem(ItemMenu itemMenu)
        {
            InitializeComponent();
            ExpanderMenu.Visibility = itemMenu.SubItems == null ? Visibility.Collapsed : Visibility.Visible;
            ListViewItemMenu.Visibility = itemMenu.SubItems == null ? Visibility.Visible : Visibility.Collapsed;

            this.DataContext = itemMenu;
        }
        private void ListViewMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //string name = (ListViewMenu.SelectedItem as SubItem).Name;
            //Transfer.Trans(name);
            MessageBox.Show("sdfsdf");
        }
        private void ListViewItemMenu_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show(lbl_header.Text);
        }

        private void ListViewItemMenu_Selected(object sender, RoutedEventArgs e)
        {
            //string name = (ListViewItemMenu.ContentTemplateSelector).ToString();

            MessageBox.Show("sdfsdf");
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("");
        }
    }
}
