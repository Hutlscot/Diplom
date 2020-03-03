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
            MessageBox.Show("Переход к заполнению договора");
        }
    }
}
