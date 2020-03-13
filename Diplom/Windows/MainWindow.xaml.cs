using Diplom.Pages;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow(User user)
        {
            InitializeComponent();
            //настройка таймера для переходов по страницам
            Transfer.Initialization();
            Manager_frame.frame = frame;
            Transfer.user = user;
            if (user.TypeUser.Name == "Юзер")
            {

                var menuRegister = new List<SubItem>();
                menuRegister.Add(new SubItem("Добавить студента"));
                menuRegister.Add(new SubItem("Список студентов"));
                menuRegister.Add(new SubItem("Список родственников"));
                var item6 = new ItemMenu("Управление студентами", menuRegister, PackIconKind.Register);

                var item1 = new ItemMenu("Управление документацией", new UserControl(), PackIconKind.FileDocumentBox);

                var menuReports = new List<SubItem>();
                menuReports.Add(new SubItem("Добавить комнату"));
                menuReports.Add(new SubItem("Список комнат"));
                var item2 = new ItemMenu("Управление общежитием", menuReports, PackIconKind.HomeEdit);

                var item0 = new ItemMenu("Главная", new UserControl(), PackIconKind.ViewDashboard);

                Menu.Children.Add(new UserControlMenuItem(item0));
                Menu.Children.Add(new UserControlMenuItem(item6));
                Menu.Children.Add(new UserControlMenuItem(item1));
                Menu.Children.Add(new UserControlMenuItem(item2));
                frame.Navigate(new Main_page());
            }
            else
            {
                var menuRegister = new List<SubItem>();
                menuRegister.Add(new SubItem("Список пользователей"));
                menuRegister.Add(new SubItem("Добавить пользователя"));
                var item6 = new ItemMenu("Управление аккаунтами", menuRegister, PackIconKind.Register);

                var item1 = new ItemMenu("Данные администратора", new UserControl(), PackIconKind.FileUser);
                Menu.Children.Add(new UserControlMenuItem(item6));
                Menu.Children.Add(new UserControlMenuItem(item1));
                Manager_frame.frame.Navigate(new List_users());
            }
        }


        private void btm_back_Click(object sender, RoutedEventArgs e)
        {
            if (Manager_frame.frame.CanGoBack)
            {
                Manager_frame.frame.GoBack();
            }
            else
            {
                Authorization auth = new Authorization();
                auth.Show();
                Close();

            }
        }
    }
}
