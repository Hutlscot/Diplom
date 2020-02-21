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
        public MainWindow()
        {
            InitializeComponent();

            var menuRegister = new List<SubItem>();
            menuRegister.Add(new SubItem("Добавить студента"));
            menuRegister.Add(new SubItem("Список студентов"));
            menuRegister.Add(new SubItem("Список родственников"));
            var item6 = new ItemMenu("Управление студентами", menuRegister, PackIconKind.Register);

            var item1 = new ItemMenu("Управление документацией",new UserControl(), PackIconKind.FileDocumentBox);

            var menuReports = new List<SubItem>();
            menuReports.Add(new SubItem("Добавить комнату"));
            menuReports.Add(new SubItem("Список комнат"));
            var item2 = new ItemMenu("Управление общежитием", menuReports, PackIconKind.HomeEdit);

            //var menuExpenses = new List<SubItem>();
            //menuExpenses.Add(new SubItem("Fixed"));
            //menuExpenses.Add(new SubItem("Variable"));
            //var item3 = new ItemMenu("Управление аккаунтами", menuExpenses, PackIconKind.ShoppingBasket);

            var item0 = new ItemMenu("Главная", new UserControl(), PackIconKind.ViewDashboard);

            Menu.Children.Add(new UserControlMenuItem(item0));
            Menu.Children.Add(new UserControlMenuItem(item6));
            Menu.Children.Add(new UserControlMenuItem(item1));
            Menu.Children.Add(new UserControlMenuItem(item2));
            //Menu.Children.Add(new UserControlMenuItem(item3));
            frame.Navigate(new Add_person());
            Manager_frame.frame = frame;
        }

        private void btm_back_MouseDown(object sender, MouseButtonEventArgs e)
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
