using System.Linq;
using System.Windows;
using System.Windows.Controls;
namespace Diplom
{
    /// <summary>
    /// Interaction logic for List_students.xaml
    /// </summary>
    public partial class List_students : Page
    {
        ConnectionEntity dbContext = new ConnectionEntity();
        Student student_selected;
        public List_students()
        {
            InitializeComponent();
            list.ItemsSource = dbContext.Students.ToList();
        }
        //запрос на подтверждение
        private void btm_delete_Click(object sender, RoutedEventArgs e)
        {
            Dialog_message.Dialog_delete_Student(student_selected, list, txt_fio.Text, Date_End);
        }//поиск
        private void txt_fio_TextChanged(object sender, TextChangedEventArgs e)
        {
            list.ItemsSource = Search.Find_Student(txt_fio.Text, Date_End);
        }//поиск
        private void Date_End_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            list.ItemsSource = Search.Find_Student(txt_fio.Text, Date_End);
        }
        //метод удаления
        private void list_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            student_selected = list.SelectedItem as Student;
        }
        private void btm_change_Click(object sender, RoutedEventArgs e)
        {
            Dialog_message.Menu_change_student(student_selected);
        }
    }
}
