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
    /// Interaction logic for List_relatives.xaml
    /// </summary>
    public partial class List_relatives : Page
    {
        ConnectionEntity dbContext = new ConnectionEntity();
        List<Student> students;
        public List_relatives()
        {
            InitializeComponent();
            students = dbContext.Students.ToList();
            list.ItemsSource = students;
        }

        private void txt_fio_TextChanged(object sender, TextChangedEventArgs e)
        {
            list.ItemsSource = Search.Find_Student(students, txt_fio.Text, Date_End);
        }

        private void Date_End_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            list.ItemsSource = Search.Find_Student(students, txt_fio.Text, Date_End);
        }
    }
}
