using MaterialDesignThemes.Wpf;
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
        DialogHost closeDialog;
        Student student;
        ListView list;
        public Dialog_add_relative(DialogHost closeDialog, Student student, ListView list)
        {
            InitializeComponent();
            txt_phone.PreviewTextInput += Val.Phone_PreviewTextInput;
            this.closeDialog = closeDialog;
            this.student = student;
            this.list = list;
        }
        private bool Validation()
        {
            if (Val.Val_txt(txt_surname) || Val.Val_txt(txt_name) || Val.Val_txt(txt_patronymic) || Val.Val_txt(txt_phone) ||
                Val.Val_txt(txt_degree) || Val.Val_txt(txt_address))
            {
                Dialog_message.DialogInDialogER(Add_window, "Заполните все поля");
                return false;
            }
            if (Val.Val_Phone(txt_phone))
            {
                Dialog_message.DialogInDialogER(Add_window, "Неверный телефон");
                return false;
            }
            return true;
        }
        private void btm_add_Click(object sender, RoutedEventArgs e)
        {
            if (Validation())
            {
                ConnectionEntity dbContext = new ConnectionEntity();
                Person man = new Person();
                man.Type = "Родственник";
                man.Name = txt_name.Text;
                man.LastName = txt_surname.Text;
                man.MiddleName = txt_patronymic.Text;
                man.Phone = txt_phone.Text;
                dbContext.People.Add(man);
                dbContext.SaveChanges();
                Relative relative = new Relative();
                relative.Id = man.Id;
                relative.Degree = txt_degree.Text;
                relative.Address = txt_address.Text;
                relative.StudentId = student.Id;
                dbContext.Relatives.Add(relative);
                dbContext.SaveChanges();
                closeDialog.IsOpen = false;
                list.ItemsSource = dbContext.Relatives.Where(x => x.StudentId == student.Id).ToList();
            }
        }
    }
}
