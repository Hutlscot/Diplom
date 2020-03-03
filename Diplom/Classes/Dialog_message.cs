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
        public static void MessageAddRelative(DialogHost CloseDialog, Student student, ListView list)
        {
            DialogHost.Show(new Dialog_add_relative(CloseDialog, student, list));
        }
        public static void DialogInDialogER(DialogHost dialog, string text)
        {
            dialog.DialogContent = new DialogERR(text);
            dialog.IsOpen = true;
        }
        public static void DialogInDialogOK(DialogHost dialog, string text)
        {
            dialog.DialogContent = new DialogOK(text);
            dialog.IsOpen = true;
        }
    }
}
