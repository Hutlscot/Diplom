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
    /// Interaction logic for Change_representative.xaml
    /// </summary>
    public partial class Change_representative : Page
    {
        ConnectionEntity dbContext = new ConnectionEntity();
        public Change_representative(Student student)
        {
            InitializeComponent();
            txt_phone.PreviewTextInput += Val.Phone_PreviewTextInput;
            txt_series.PreviewTextInput += Val.Series_PreviewTextInput;
            txt_number.PreviewTextInput += Val.Number_PreviewTextInput;
            txt_division_code.PreviewTextInput += Val.Code_PreviewTextInput;
            txt_home_phone.PreviewTextInput += Val.Home_Phone_PreviewTextInput;
            DataContext = dbContext.Students.Find(student.Id);
            dbContext.Students.Attach(DataContext as Student);
        }

        private void btm_next_Click(object sender, RoutedEventArgs e)
        {
            if(Validation())
            {
                dbContext.SaveChanges();
                Transfer.Trans("Список студентов");
            }
        }
        private bool Validation()
        {
            if (Val.Val_txt(txt_surname) || Val.Val_txt(txt_name) || Val.Val_txt(txt_patronymic) ||
                Val.Val_txt(txt_phone) || Val.Val_txt(txt_place_of_work) || Val.Val_txt(txt_series) ||
                Val.Val_txt(txt_number) || Val.Val_txt(txt_who_gave) || Val.Val_txt(txt_address) ||
                Val.Val_txt(txt_division_code) || Val.Val_txt(txt_place_of_live) || Val.Val_txt(txt_home_phone) ||
                Val.Val_cmb(cmb_type) || Date_of_issue.SelectedDate == null)
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
