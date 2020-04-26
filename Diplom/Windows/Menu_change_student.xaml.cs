using System.Windows;
using System.Windows.Controls;
namespace Diplom
{
    /// <summary>
    /// Interaction logic for Menu_change_user.xaml
    /// </summary>
    public partial class Menu_change_student : UserControl
    {
        Student student_changed;
        public Menu_change_student(Student student_changed)
        {
            InitializeComponent();
            this.student_changed = student_changed;
        }
        private void btm_change_student_Click(object sender, RoutedEventArgs e)
        {
            Transfer.Change_student("Редактировать студента", student_changed);
        }
        private void btm_change_representative_Click(object sender, RoutedEventArgs e)
        {
            Transfer.Change_student("Редактировать представителя", student_changed);
        }
        private void btm_change_relative_Click(object sender, RoutedEventArgs e)
        {
            Transfer.Change_student("Редактировать родственников", student_changed);
        }
        private void btm_change_contract_Click(object sender, RoutedEventArgs e)
        {
            Transfer.Change_student("Редактировать договор", student_changed);
        }
    }
}
