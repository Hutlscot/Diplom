using System.Windows.Controls;
namespace Diplom
{
    /// <summary>
    /// Interaction logic for DialogERR.xaml
    /// </summary>
    public partial class DialogERR : UserControl
    {
        public DialogERR(string text)
        {
            InitializeComponent();
            text_message.Text = text;
        }
    }
}
