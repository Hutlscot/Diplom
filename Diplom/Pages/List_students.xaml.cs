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
    /// Interaction logic for List_students.xaml
    /// </summary>
    public partial class List_students : Page
    {
        ConnectionEntity dbContext = new ConnectionEntity();
        List<Student> students;
        Student student_selected;
        public List_students()
        {
            InitializeComponent();
            students = dbContext.Students.ToList();
            list.ItemsSource = students;
        }

        private void btm_delete_Click(object sender, RoutedEventArgs e)
        {
            text_message.Text = "Удалить\n"+student_selected.Person.FIO+" ?";
            Warning.IsOpen = true;
        }
        private void txt_fio_TextChanged(object sender, TextChangedEventArgs e)
        {
            list.ItemsSource = students.Where(x => x.Person.LastName.ToLower().Contains(txt_fio.Text.ToLower())).ToList();
        }
        private void btm_OK_Click(object sender, RoutedEventArgs e)
        {
            int rep = student_selected.Representatives.FirstOrDefault().Person.Id;
            int rel = student_selected.Relatives.FirstOrDefault().Person.Id;
            int stud = student_selected.Person.Id;
            dbContext.Students.Remove(student_selected);
            dbContext.People.Remove(dbContext.People.Find(rep));
            dbContext.People.Remove(dbContext.People.Find(rel));
            dbContext.People.Remove(dbContext.People.Find(stud));
            dbContext.SaveChanges();
            list.ItemsSource = dbContext.Students.Where(x => x.Person.LastName.ToLower().Contains(txt_fio.Text.ToLower())).ToList();
        }
        private void list_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            student_selected = list.SelectedItem as Student;
        }
    }
}
