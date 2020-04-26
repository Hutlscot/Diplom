using System.Windows.Controls;
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
