using System.Linq;
using System.Windows;
using System.Windows.Controls;
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
            text_message.Text = "Удалить\nкомнату № " + room_selected.Number + " ?";
            Warning.IsOpen = true;
        }
        private void list_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            room_selected = list.SelectedItem as Room;
        }
        private void btm_OK_Click(object sender, RoutedEventArgs e)
        {
            dbContext.Rooms.Remove(room_selected);
            dbContext.SaveChanges();
            list.ItemsSource = dbContext.Rooms.ToList();
        }
    }
}
