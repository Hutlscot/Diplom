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
    /// Interaction logic for List_students.xaml
    /// </summary>
    public partial class List_students : Page
    {
        ConnectionEntity dbContext = new ConnectionEntity();
        public List_students()
        {
            InitializeComponent();
            list.ItemsSource = dbContext.Students.ToList();
        }

        private void btm_delete_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show((list.SelectedItem as Student).Group.ToString());
        }
    }
}
