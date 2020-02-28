using MaterialDesignThemes.Wpf;
using System.Windows;
using System.Windows.Controls;

namespace Diplom
{
    public static class Dialog_message
    {
        public static void MessageOK(string text)
        {
            DialogHost.Show(new DialogOK(text));
        }
        public static void MessageER(string text)
        {
            DialogHost.Show(new DialogERR(text));
        }
        public static void MessageProgress(string text)
        {
            DialogHost.Show(new DialogProgressBar(text));
        }
    }
}
