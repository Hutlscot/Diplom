using System;
using System.Linq;
using System.Windows;
using System.Windows.Threading;

namespace Diplom
{
    /// <summary>
    /// Interaction logic for Authorization.xaml
    /// </summary>
    public partial class Authorization : Window
    {
        int errors = 0;
        int block = 0;
        int time = 10;
        static DispatcherTimer timer = new DispatcherTimer();
        public Authorization()
        {
            InitializeComponent();
            timer.Tick += new EventHandler(TimerStart);
            timer.Interval = new TimeSpan(0, 0, 0, 0, 1000);
        }
      
        private void btm_input_Click(object sender, RoutedEventArgs e)
        {
            if (Val.Val_txt(txt_login) || string.IsNullOrEmpty(txt_password.Password))
            {
                Dialog_message.MessageER("Заполните поля");
                return;
            }
            if(txt_login.Text=="admin"||txt_password.Password=="admin")
            {
                Dialog_message.Dialog_change_connectionString();
                return;
            }
            using (ConnectionEntity dbContext = new ConnectionEntity())
            {
                string password = Cryptographer.Coding(txt_password.Password);
                User user = dbContext.Users.Where(x => x.Login == txt_login.Text && x.Password == password).FirstOrDefault() as User;
                if (user != null)
                {
                    TimerStop();
                    MainWindow main = new MainWindow(user);
                    main.Show();
                    Close();
                }
                else
                {
                    TimerStop();
                    errors++;
                    Dialog_message.MessageER("Неверный логин или пароль");
                    if (errors >= 3)
                    {
                        btm_input.IsEnabled = false;
                        txt_message.Visibility = Visibility.Visible;
                        timer.Start();
                    }
                }
            }

        }
        private void TimerStart(object sender, EventArgs e)
        {
            block++;
            txt_message.Text = "Подождите " + (time - block).ToString() + "\nдо следующей попытки входа";
            if (block == time)
            {
                btm_input.IsEnabled = true;
                txt_message.Visibility = Visibility.Hidden;
                block = 0;
                time *= 2;
                TimerStop();
            }
        }
        private void TimerStop()
        {
            timer.Stop();
        }
    }
}
