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
    /// Interaction logic for Change_db.xaml
    /// </summary>
    public partial class Change_db : Page
    {
        public Change_db()
        {
            InitializeComponent();
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");
            string s = connectionStringsSection.ConnectionStrings["ConnectionEntity"].ConnectionString;
            txt_server.Text = Get_ConnectionString_Old(s, "data source=");
            txt_catalog.Text = Get_ConnectionString_Old(s, "initial catalog=");
        }

        private void btm_save_Click(object sender, RoutedEventArgs e)
        {
            if(string.IsNullOrEmpty(txt_catalog.Text)||string.IsNullOrEmpty(txt_server.Text))
            {
                Dialog_message.MessageER("Заполните все поля");
                return;
            }
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");
            string s = connectionStringsSection.ConnectionStrings["ConnectionEntity"].ConnectionString;
            s = Change_ConnectionString(s, "data source=", txt_server.Text);
            s = Change_ConnectionString(s, "initial catalog=", txt_catalog.Text);
            connectionStringsSection.ConnectionStrings["ConnectionEntity"].ConnectionString = s;
            config.Save();
            Dialog_message.MessageOK("Сохранено\nПерезагрузите приложение");
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
