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
            string name = (ListViewMenu.SelectedItem as SubItem).Name;
            switch (name)
            {
                case "Добавить студента":
                    Manager_frame.frame.Navigate(new Add_person());
                    break;
                case "Список студентов":
                    Manager_frame.frame.Navigate(new List_students());
                    break;
            }
        }

        private void ExpanderMenu_Expanded(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("sdfsdf");
        }

        private void ExpanderMenu_MouseDown(object sender, MouseButtonEventArgs e)
        {
            string name = (sender as Expander).Header as string;
            switch (name)
            {
                case "Главная":
                    Manager_frame.frame.Navigate(new Main_page());
                    break;
                case "Добавить студента":
                    Manager_frame.frame.Navigate(new Add_person());
                    break;
                case "Список студентов":
                    Manager_frame.frame.Navigate(new List_students());
                    break;
            }
        }
    }
}
