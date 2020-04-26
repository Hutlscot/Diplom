using System.Windows.Controls;
namespace Diplom
{
    /// <summary>
    /// Interaction logic for DialogProgressBar.xaml
    /// </summary>
    public partial class DialogProgressBar : UserControl
    {
        public DialogProgressBar(string text)
        {
            InitializeComponent();
            text_message.Text = text;
        }
    }
}
