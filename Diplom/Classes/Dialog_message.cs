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
        public static void MessageAddRelative(DialogHost CloseDialog, Student student, DataGrid list)
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
        public static void Dialog_Delete(string text, bool close)
        {
            DialogHost.Show(new Dialog_WARNING(text, close));
        }
        public static void Menu_change_student(Student student_changed)
        {
            DialogHost.Show(new Menu_change_student(student_changed));
        }
        public static void Dialog_delete_Student(Student student, DataGrid list, string fio, DatePicker dateEnd)
        {
            DialogHost.Show(new Dialog_delete_student(student, list, fio, dateEnd));
        }
    }
}
