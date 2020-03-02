using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Diplom
{
    /// <summary>
    /// Interaction logic for Authorization.xaml
    /// </summary>
    public partial class Authorization : Window
    {
        static int GoOver = 0;
        static DispatcherTimer timer = new DispatcherTimer();
        public Authorization()
        {
            InitializeComponent();
            timer.Tick += new EventHandler(TimerStart);
            timer.Interval = new TimeSpan(0, 0, 0, 0, 500);
        }
      
        private void btm_input_Click(object sender, RoutedEventArgs e)
        {
            if (Val.Val_txt(txt_login) || string.IsNullOrEmpty(txt_password.Password))
            {
                Dialog_message.MessageER("Заполните поля");
                return;
            }
            using (ConnectionEntity dbContext = new ConnectionEntity())
            {
                User user = dbContext.Users.Where(x => x.Login == txt_login.Text && x.Password == txt_password.Password) as User;
                if (user!=null)
                {
                    TimerStop();
                    MainWindow main = new MainWindow();
                    main.Show();
                    Close();
                }

                else
                {
                    TimerStop();
                    Dialog_message.MessageER("Неверный логин или пароль");
                }
            }

        }
        private void TimerStart(object sender, EventArgs e)
        {
            GoOver++;
            if(GoOver==1)
            {
                
            }
        }
        private void TimerStop()
        {
            timer.Stop();
            GoOver = 0;
        }
    }
}
