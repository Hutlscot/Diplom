using System;
using System.Collections.Generic;
using System.Data.Entity;
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
    /// Interaction logic for Page_admin.xaml
    /// </summary>
    public partial class Page_admin : Page
    {
        ConnectionEntity dbContext = new ConnectionEntity();
        
        private string Greeting()
        {
            User user = dbContext.Users.Find(Transfer.user.Id);
            if (DateTime.Now.Hour >= 0 && DateTime.Now.Hour < 4)
            {
                return "Доброй ночи, " + user.Person.Name_Patronymic + "!";
            }
            if (DateTime.Now.Hour >= 4 && DateTime.Now.Hour < 12)
            {
            return "Доброе утро, " + user.Person.Name_Patronymic + "!";
            }
            if (DateTime.Now.Hour >= 12 && DateTime.Now.Hour < 18)
            {
            return "Добрый день, " + user.Person.Name_Patronymic + "!";
            }
            return "Добрый вечер, " + user.Person.Name_Patronymic + "!";
        }
        public Page_admin()
        {
            InitializeComponent();
            DataContext = dbContext.Users.Find(Transfer.user.Id);
            dbContext.Users.Attach(DataContext as User);
            (DataContext as User).Password = "";
            title.Text = Greeting();
        }
        private void btm_save_Click(object sender, RoutedEventArgs e)
        {
            if(txt_login.Text.Length<5||txt_password.Text.Length<5)
            {
                Dialog_message.MessageER("Некорректные\nданные");
                return;
            }
            dbContext.SaveChanges();
            Dialog_message.MessageOK("Сохранено");
            Transfer.Trans("Данные администратора");
        }
    }
}
