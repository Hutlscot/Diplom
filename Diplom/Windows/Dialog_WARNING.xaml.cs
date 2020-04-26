using System.Windows;
using System.Windows.Controls;

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
