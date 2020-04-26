using System.Linq;
using System.Windows;
using System.Windows.Controls;
namespace Diplom
{
    /// <summary>
    /// Interaction logic for List_users.xaml
    /// </summary>
    public partial class List_users : Page
    {
        ConnectionEntity dbContext = new ConnectionEntity();
        User user_selected = new User();
        public List_users()
        {
            InitializeComponent();
            list.ItemsSource = dbContext.Users.ToList();
        }
        private void list_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            user_selected = list.SelectedItem as User;
        }
        private void btm_delete_Click(object sender, RoutedEventArgs e)
        {
            Warning.IsOpen = true;
        }
        private void btm_change_Click(object sender, RoutedEventArgs e)
        {
            Transfer.Change_user("Редактировать пользователя", user_selected);
        }
        private void txt_fio_TextChanged(object sender, TextChangedEventArgs e)
        {
            list.ItemsSource = Search.Find_user(txt_fio.Text);
        }
        private void btm_OK_Click(object sender, RoutedEventArgs e)
        {
            int per = user_selected.Id;
            dbContext.Users.Remove(user_selected);
            dbContext.People.Remove(dbContext.People.Find(per));
            dbContext.SaveChanges();
            list.ItemsSource = Search.Find_user(txt_fio.Text);
        }
    }
}
