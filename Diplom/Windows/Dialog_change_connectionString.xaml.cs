using System;
using System.Collections.Generic;
using System.Configuration;
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
    /// Interaction logic for Dialog_change_connectionString.xaml
    /// </summary>
    public partial class Dialog_change_connectionString : UserControl
    {
        public Dialog_change_connectionString()
        {
            InitializeComponent();
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");
            string s = connectionStringsSection.ConnectionStrings["ConnectionEntity"].ConnectionString;
            txt_server.Text = Get_ConnectionString_Old(s, "data source=");
            txt_catalog.Text = Get_ConnectionString_Old(s, "initial catalog=");
            title.Text = "Настройка\nстроки подключения";
        }

        private void btm_add_Click(object sender, RoutedEventArgs e)
        {
            if(Val.Val_txt(txt_server)||Val.Val_txt(txt_catalog))
            {
                Dialog_message.DialogInDialogER(Add_window, "Заполните все поля");
                return;
            }
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");
            string s = connectionStringsSection.ConnectionStrings["ConnectionEntity"].ConnectionString;
            s = Change_ConnectionString(s, "data source=", txt_server.Text);
            s = Change_ConnectionString(s, "initial catalog=", txt_catalog.Text);
            connectionStringsSection.ConnectionStrings["ConnectionEntity"].ConnectionString = s;
            config.Save();
            Dialog_message.DialogInDialogOK(Add_window, "Сохранено\n перезагрузитесь");
            
        }

        public string Change_ConnectionString(string connectionString, string find_text, string value)
        {
            int x = connectionString.IndexOf(find_text);
            string i = connectionString.Substring(x);
            int y = i.IndexOf(";");
            string v = i.Substring(find_text.Length, y - find_text.Length);
            return connectionString.Replace(v, value);
        }
        public string Get_ConnectionString_Old(string connectionString, string find_text)
        {
            int x = connectionString.IndexOf(find_text);
            string i = connectionString.Substring(x);
            int y = i.IndexOf(";");
            return i.Substring(find_text.Length, y - find_text.Length);
        }
    }
}
