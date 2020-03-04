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
    /// Interaction logic for Add_contract.xaml
    /// </summary>
    public partial class Add_contract : Page
    {
        Student student;
        public Add_contract(Student student)
        {
            InitializeComponent();
            this.student = student;
        }

        private void btm_add_contract_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("ня пока");
        }
    }
}
