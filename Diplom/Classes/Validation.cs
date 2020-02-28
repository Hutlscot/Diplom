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
            if (txt.Text.Length ==17)
            {
                return false;
            }
            return true;
        }
        //проверка серии паспорта
        public static bool Val_series(TextBox txt)
        {
            if(txt.Text.Length==5)
            {
                return false;
            }
            return true;
        }
        //проверка номера паспорта
        public static bool Val_number(TextBox txt)
        {
            if(txt.Text.Length==6)
            {
                return false;
            }
            return true;
        }
        //проверка кода подразделения
        public static bool Val_code(TextBox txt)
        {
            if(txt.Text.Length==7)
            {
                return false;
            }
            return true;
        }
    }
}
