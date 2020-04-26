using System.Linq;
using System.Windows.Controls;
namespace Diplom
{
    /// <summary>
    /// Interaction logic for List_relatives.xaml
    /// </summary>
    public partial class List_relatives : Page
    {
        ConnectionEntity dbContext = new ConnectionEntity();
        public List_relatives()
        {
            InitializeComponent();
            list.ItemsSource = dbContext.Students.ToList();
        }
        private void txt_fio_TextChanged(object sender, TextChangedEventArgs e)
        {
            list.ItemsSource = Search.Find_Student(txt_fio.Text, Date_End);
        }
        private void Date_End_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            list.ItemsSource = Search.Find_Student(txt_fio.Text, Date_End);
        }
    }
}
