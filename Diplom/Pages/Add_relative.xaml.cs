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

        List<Relative> list = new List<Relative>();
        Person per = new Person { Name = "Руслан", LastName = "Камалов", MiddleName = "Владиславович", Phone="8(953)-965-01-23"};
        Relative rel = new Relative { Degree = "Папочка", Address = "Семилужки" };
        public Add_relative()
        { 
            InitializeComponent();
            rel.Person = per;
            list.Add(rel);
            lists.ItemsSource = list;
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

        private void btm_cancel_Click(object sender, RoutedEventArgs e)
        {
            add_window.IsOpen = false;
        }

        private void btm_add_Click(object sender, RoutedEventArgs e)
        {
            if (Validation())
            {
                Person person = new Person { Name = txt_name.Text, MiddleName = txt_patronymic.Text, LastName = txt_surname.Text, Phone=txt_phone.Text};
                Relative relative = new Relative { Degree = txt_degree.Text, Address = txt_address.Text };
                relative.Person = person;
                list.Add(relative);
                lists.Items.Refresh();
                add_window.IsOpen = false;
            }
        }
        private bool Validation()
        {
            if (Val.Val_txt(txt_surname) || Val.Val_txt(txt_name) || Val.Val_txt(txt_patronymic) || Val.Val_txt(txt_phone) ||
                Val.Val_txt(txt_degree) || Val.Val_txt(txt_address))
            {
                MessageBox.Show("Заполните все поля");
                return false;
            }
            if (Val.Val_Phone(txt_phone))
            {
                return false;
            }
            MessageBox.Show("Сохранено");
            return true;
        }
    }
}
