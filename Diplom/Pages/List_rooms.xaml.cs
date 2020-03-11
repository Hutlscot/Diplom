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
    /// Interaction logic for List_rooms.xaml
    /// </summary>
    public partial class List_rooms : Page
    {
        ConnectionEntity dbContext = new ConnectionEntity();
        Room room_selected;
        public List_rooms()
        {
            InitializeComponent();
            list.ItemsSource = dbContext.Rooms.ToList();
        }

        private void btm_delete_Click(object sender, RoutedEventArgs e)
        {
            //dbContext.Rooms.Remove(room_selected);
            //dbContext.SaveChanges();
            //list.ItemsSource = dbContext.Rooms.ToList();
        }
        private void list_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            room_selected = list.SelectedItem as Room;
        }
    }
}
