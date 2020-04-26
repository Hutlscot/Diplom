using System.Linq;
using System.Windows;
using System.Windows.Controls;
namespace Diplom
{
    /// <summary>
    /// Interaction logic for Add_relative.xaml
    /// </summary>
    public partial class Add_relative : Page
    {
        Student student;
        ConnectionEntity dbContext = new ConnectionEntity();
        public Add_relative(Student student)
        { 
            InitializeComponent();
            this.student = student;
            list.ItemsSource = dbContext.Relatives.Where(x => x.StudentId == student.Id).ToList();
        }
        private void btm_open_window_add_Click(object sender, RoutedEventArgs e)
        {
            Dialog_message.MessageAddRelative(CloseDialog, student, list);
        }
        private void btm_next_Click(object sender, RoutedEventArgs e)
        {
            Transfer.Add("Добавить договор", student);
        }
    }
}
