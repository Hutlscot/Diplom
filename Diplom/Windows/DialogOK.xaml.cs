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
    /// Interaction logic for DialogOK.xaml
    /// </summary>
    public partial class DialogOK : UserControl
    {
        public DialogOK(string text)
        {
            InitializeComponent();
            text_message.Text = text;
        }
    }
}
