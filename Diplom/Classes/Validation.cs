using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Diplom
{
    static public class Val
    {
        public static bool Val_txt(TextBox txt)
        {
            if(string.IsNullOrEmpty(txt.Text))
            {
                Dialog_message.MessageER("Заполните все поля");
                return true;
            }
            return false;
        }
        public static bool Val_cmb(ComboBox cmb)
        {
            if(cmb.SelectedItem==null)
            {
                return true;
            }
            return false;
        }
        //проверка номера телефона
        public static bool Val_Phone(TextBox txt)
        {
            if (txt.Text.Length !=17)
            {
                Dialog_message.MessageER("Неверный телефон");
                return true;
            }
            return false;
        }
        //проверка серии паспорта
        public static bool Val_series(TextBox txt)
        {
            if(txt.Text.Length!=5)
            {
                Dialog_message.MessageER("Неверная серия");
                return true;
            }
            return false;
        }
        //проверка номера паспорта
        public static bool Val_number(TextBox txt)
        {
            if(txt.Text.Length!=6)
            {
                Dialog_message.MessageER("Неверный номер");
                return true;
            }
            return false;
        }
        //проверка кода подразделения
        public static bool Val_code(TextBox txt)
        {
            if(txt.Text.Length!=7)
            {
                Dialog_message.MessageER("Неверный код");
                return true;
            }
            return false;
        }
        //маска для ввода числа типа float/double
        public static void Number_room_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty((sender as TextBox).Text))
            {
                return;
            }
            if (!double.TryParse((sender as TextBox).Text, out var x))
            {
                (sender as TextBox).Text = (sender as TextBox).Text.Substring(0, (sender as TextBox).Text.Length - 1);
                (sender as TextBox).SelectionStart = (sender as TextBox).Text.Length;
            }
        }
        //маска для телефона
        public static void Phone_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !(Char.IsDigit(e.Text, 0));
            Phone_mask(sender as TextBox);
        }
        private static void Phone_mask(TextBox txt)
        {
            if (txt.Text.Length == 1)
            {
                txt.Text = '+' + txt.Text;
            }
            if (txt.Text.Length == 2)
            {
                txt.Text += '(';
            }
            if (txt.Text.Length == 6)
            {
                txt.Text += ")-";
            }
            if (txt.Text.Length == 11)
            {
                txt.Text += '-';
            }
            if (txt.Text.Length == 14)
            {
                txt.Text += '-';
            }
            txt.SelectionStart = txt.Text.Length;
        }
        //маска для номера паспорта
        public static void Number_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !(Char.IsDigit(e.Text, 0));
        }
        //маска для серии паспорта
        public static void Series_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !(Char.IsDigit(e.Text, 0));
            if ((sender as TextBox).Text.Length == 2)
            {
                (sender as TextBox).Text += ' ';
            }
            (sender as TextBox).SelectionStart = (sender as TextBox).Text.Length;
        }
        //маска для кода подразделения
        public static void Code_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !(Char.IsDigit(e.Text, 0));
            if ((sender as TextBox).Text.Length == 3)
            {
                (sender as TextBox).Text += '-';
            }
            (sender as TextBox).SelectionStart = (sender as TextBox).Text.Length;
        }
        //маска для домашнего телефона
        public static void Home_Phone_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !(Char.IsDigit(e.Text, 0));
            if ((sender as TextBox).Text.Length == 3)
            {
                (sender as TextBox).Text += '-';
            }
            (sender as TextBox).SelectionStart = (sender as TextBox).Text.Length;
        }
    }
}
