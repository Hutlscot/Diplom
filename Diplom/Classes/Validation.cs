using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

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
    }
}
