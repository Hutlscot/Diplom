using System.Linq;
using System.Windows;
using System.Windows.Controls;
namespace Diplom
{
    /// <summary>
    /// Interaction logic for Change_relative.xaml
    /// </summary>
    public partial class Change_relative : Page
    {
        ConnectionEntity dbContext = new ConnectionEntity();
        Student student_changed;
        Relative relative = new Relative();
        public Change_relative(Student student)
        {
            InitializeComponent();
            student_changed = student;
            list.ItemsSource = dbContext.Relatives.Where(x => x.StudentId == student.Id).ToList();
        }
        private void list_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            relative = list.SelectedItem as Relative;
        }
        private void btm_delete_Click(object sender, RoutedEventArgs e)
        {
            dbContext.Relatives.Remove(dbContext.Relatives.Find(relative.Id));
            dbContext.SaveChanges();
            list.ItemsSource = dbContext.Relatives.Where(x => x.StudentId == student_changed.Id).ToList();
            Dialog_message.MessageOK("Успешно");
        }
        private void btm_open_window_add_Click(object sender, RoutedEventArgs e)
        {
            Dialog_message.MessageAddRelative(CloseDialog, student_changed, list);
        }

        private void btm_next_Click(object sender, RoutedEventArgs e)
        {
            Dialog_message.MessageOK("Сохранено");
            Manager_frame.frame.GoBack();
        }
    }
}
