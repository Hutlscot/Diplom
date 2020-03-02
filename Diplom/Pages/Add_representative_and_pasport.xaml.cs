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
    /// Interaction logic for Add_representative_and_pasport.xaml
    /// </summary>
    public partial class Add_representative_and_pasport : Page
    {
        Student student;
        public Add_representative_and_pasport(Student student)
        {
            InitializeComponent();
            this.student = student;
        }
        private void txt_phone_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !(Char.IsDigit(e.Text, 0));
            Validation_phone();
        }
        private void Validation_phone()
        {
            if (txt_phone.Text.Length == 1)
            {
                txt_phone.Text = '+' + txt_phone.Text;
            }
            if (txt_phone.Text.Length == 2)
            {
                txt_phone.Text += '(';
            }
            if (txt_phone.Text.Length == 6)
            {
                txt_phone.Text += ")-";
            }
            if (txt_phone.Text.Length == 11)
            {
                txt_phone.Text += '-';
            }
            if (txt_phone.Text.Length == 14)
            {
                txt_phone.Text += '-';
            }
            txt_phone.SelectionStart = txt_phone.Text.Length;
        }
        private void txt_series_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !(Char.IsDigit(e.Text, 0));
            if (txt_series.Text.Length == 2)
            {
                txt_series.Text += ' ';
            }
            txt_series.SelectionStart = txt_series.Text.Length;
        }
        private void txt_division_code_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !(Char.IsDigit(e.Text, 0));
            if (txt_division_code.Text.Length == 3)
            {
                txt_division_code.Text += '-';
            }
            txt_division_code.SelectionStart = txt_division_code.Text.Length;
        }
        private void txt_number_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !(Char.IsDigit(e.Text, 0));
        }
        private void btm_next_Click(object sender, RoutedEventArgs e)
        {
            if (Validation())
            {
                ConnectionEntity dbContex = new ConnectionEntity();
                Person man = new Person();
                man.Type = "Представитель";
                man.LastName = txt_surname.Text;
                man.Name = txt_name.Text;
                man.MiddleName = txt_patronymic.Text;
                man.Phone = txt_phone.Text;
                dbContex.People.Add(man);
                dbContex.SaveChanges();
                Representative rep = new Representative();
                rep.Id = man.Id;
                rep.Type = cmb_type.SelectedIndex+1;
                rep.PlaceOfWork = txt_place_of_work.Text;
                rep.Residence = txt_place_of_live.Text;
                rep.HomePhone = txt_home_phone.Text;
                rep.StudentId = student.Id;
                dbContex.Representatives.Add(rep);
                Pasport pasport = new Pasport();
                pasport.Series = txt_series.Text;
                pasport.Number = txt_number.Text;
                pasport.WhoGave = txt_who_gave.Text;
                pasport.DateGet = Date_of_issue.SelectedDate.Value;
                pasport.Address = txt_address.Text;
                pasport.DevisionCode = txt_division_code.Text;
                pasport.PersonId = man.Id;
                dbContex.Pasports.Add(pasport);
                dbContex.SaveChanges();
                Transfer.Add("Добавить родственников", student);
            }
        }

        private void txt_home_phone_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !(Char.IsDigit(e.Text, 0));
            if (txt_home_phone.Text.Length == 3)
            {
                txt_home_phone.Text += '-';
            }
            txt_home_phone.SelectionStart = txt_home_phone.Text.Length;
        }
        private bool Validation()
        {
            if (Val.Val_txt(txt_surname) || Val.Val_txt(txt_name) || Val.Val_txt(txt_patronymic) ||
                Val.Val_txt(txt_phone) || Val.Val_txt(txt_place_of_work) || Val.Val_txt(txt_series) ||
                Val.Val_txt(txt_number) || Val.Val_txt(txt_who_gave) || Val.Val_txt(txt_address) ||
                Val.Val_txt(txt_division_code) ||Val.Val_txt(txt_place_of_live)||Val.Val_txt(txt_home_phone)||
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
