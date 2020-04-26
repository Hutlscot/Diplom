using System.Windows;
using System.Windows.Controls;
namespace Diplom
{
    /// <summary>
    /// Interaction logic for Change_student.xaml
    /// </summary>
    public partial class Change_student : Page
    {
        ConnectionEntity dbContext = new ConnectionEntity();
        public Change_student(Student student)
        {
            InitializeComponent();
            DataContext = dbContext.Students.Find(student.Id);
            dbContext.Students.Attach(DataContext as Student);
        }
        private void btm_next_Click(object sender, RoutedEventArgs e)
        {
            if (Validation())
            {
                dbContext.SaveChanges();
                Transfer.Trans("Список студентов");
            }
        }
        private bool Validation()
        {
            if (Val.Val_txt(txt_surname) || Val.Val_txt(txt_name) || Val.Val_txt(txt_patronymic) ||
                Val.Val_txt(txt_phone) || Val.Val_txt(txt_group) || Val.Val_txt(txt_series) ||
                Val.Val_txt(txt_number) || Val.Val_txt(txt_who_gave) || Val.Val_txt(txt_address) ||
                Val.Val_txt(txt_division_code) || Date_of_birth.SelectedDate == null || Date_of_issue.SelectedDate == null)
            {
                return false;
            }
            if (Val.Val_Phone(txt_phone))
            {
                return false;
            }
            if (Val.Val_series(txt_series) || Val.Val_number(txt_number) || Val.Val_code(txt_division_code))
            {
                return false;
            }
            Dialog_message.MessageOK("Сохранено");
            return true;
        }
    }
}
