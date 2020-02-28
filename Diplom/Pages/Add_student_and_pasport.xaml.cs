using MaterialDesignThemes.Wpf;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Interaction logic for Add_person.xaml
    /// </summary>
    public partial class Add_person : Page
    {
        public Add_person()
        {
            InitializeComponent();
        }
        private void txt_phone_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !(Char.IsDigit(e.Text, 0));
            Validation_phone();
        }
        //маска для телефона
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
            //if (Validation())
            //{
                Dialog_message.MessageOK("Сохранено");
                Transfer.Trans("Добавить представителя");
            //}
        }
        //метод для загрузки фото
        private void btm_load_photo_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "PNG Фото (*.png)|*.png|JPG Фото (*.jpg)|*.jpg|JPEG Фото (*.jpeg)|*.jpeg";
            if (openFile.ShowDialog() == true)
            {
                string directory = openFile.FileName;
                byte[] img = File.ReadAllBytes(directory);
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
            if(Val.Val_Phone(txt_phone))
            {
                return false;
            }
            if(Val.Val_series(txt_series)||Val.Val_number(txt_number)||Val.Val_code(txt_division_code))
            {
                return false;
            }
            Dialog_message.MessageOK("Сохранено");
            return true;
        }

    }
}