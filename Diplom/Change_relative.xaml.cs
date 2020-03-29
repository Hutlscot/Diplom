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
    /// Interaction logic for Change_relative.xaml
    /// </summary>
    public partial class Change_relative : Page
    {
        //ConnectionEntity dbContext = new ConnectionEntity();
        Student student_changed;
        Relative relative = new Relative();
        public Change_relative(Student student)
        {
            InitializeComponent();
            student_changed = student;
            list.ItemsSource = student.Relatives.ToList();
        }

        private void list_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            relative = list.SelectedItem as Relative;
        }

        private void btm_delete_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void btm_open_window_add_Click(object sender, RoutedEventArgs e)
        {
            Dialog_message.MessageAddRelative(CloseDialog, student_changed, list);
        }
    }
}
