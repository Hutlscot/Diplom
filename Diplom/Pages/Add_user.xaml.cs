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
    /// Interaction logic for Add_user.xaml
    /// </summary>
    public partial class Add_user : Page
    {
        ConnectionEntity dbContext = new ConnectionEntity();
        public Add_user()
        {
            InitializeComponent();
        }

        private void btm_create_Click(object sender, RoutedEventArgs e)
        {
            if (Validation())
            {
                Person person = new Person();
                person.Name = txt_name.Text;
                person.Type = "Пользователь";
                person.LastName = txt_surname.Text;
                person.MiddleName = txt_patronymic.Text;
                dbContext.People.Add(person);
                dbContext.SaveChanges();
                User user = new User();
                user.Id = person.Id;
                user.Login = txt_login.Text;
                user.Password = txt_password.Text;
                user.TypeUserId = cmb_type.SelectedIndex + 1;
                dbContext.Users.Add(user);
                dbContext.SaveChanges();
                Transfer.Trans("Добавить пользователя");
            }
        }
        private bool Validation()
        {
            if(Val.Val_txt(txt_name)||Val.Val_txt(txt_surname)||Val.Val_txt(txt_patronymic)
                ||Val.Val_txt(txt_login)||Val.Val_txt(txt_password)||Val.Val_cmb(cmb_type))
            {
                return false;
            }
            if (txt_login.Text.Length < 5 || txt_password.Text.Length<8)
            {
                Dialog_message.MessageER("Некорретные\nданные");
                return false;
            }
            Dialog_message.MessageOK("Сохранено");
            return true;
        }
    }
}
