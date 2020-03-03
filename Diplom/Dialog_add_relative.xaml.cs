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
    /// Interaction logic for Dialog_add_relative.xaml
    /// </summary>
    public partial class Dialog_add_relative : UserControl
    {
        public Dialog_add_relative()
        {
            InitializeComponent();
            txt_phone.PreviewTextInput += Val.Phone_PreviewTextInput;
        }
        private bool Validation()
        {
            if (Val.Val_txt(txt_surname) || Val.Val_txt(txt_name) || Val.Val_txt(txt_patronymic) || Val.Val_txt(txt_phone) ||
                Val.Val_txt(txt_degree) || Val.Val_txt(txt_address))
            {
                Dialog_message.MessageER("Заполните все поля");
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
