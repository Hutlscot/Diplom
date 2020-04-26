using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
namespace Diplom
{
    /// <summary>
    /// Interaction logic for UserControlMenuItem.xaml
    /// </summary>
    public partial class UserControlMenuItem : UserControl
    {
        public UserControlMenuItem(ItemMenu itemMenu)
        {
            InitializeComponent();
            ExpanderMenu.Visibility = itemMenu.SubItems == null ? Visibility.Collapsed : Visibility.Visible;
            ListViewItemMenu.Visibility = itemMenu.SubItems == null ? Visibility.Visible : Visibility.Collapsed;

            this.DataContext = itemMenu;
        }
        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            string name = (sender as TextBlock).Text;
            Transfer.Trans(name);
        }
    }
}
