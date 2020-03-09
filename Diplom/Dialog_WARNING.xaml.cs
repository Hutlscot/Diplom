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
    /// Interaction logic for Dialog_WARNING.xaml
    /// </summary>
    public partial class Dialog_WARNING : UserControl
    {
        bool close;
        public Dialog_WARNING(string text, bool close)
        {
            this.close = close;
            InitializeComponent();
            text_message.Text = text;
        }

        private void btm_cancel_Click(object sender, RoutedEventArgs e)
        {
            close = false;
        }

        private void btm_OK_Click(object sender, RoutedEventArgs e)
        {
            close = true;
        }
    }
}
