using MaterialDesignThemes.Wpf;
using System.Windows;
using System.Windows.Controls;

namespace Diplom
{
    public static class Dialog_message
    {
        public static void MessageOK()
        {
            DialogHost.Show(new DialogOK("Успешно"));
        }
        public static void MessageER()
        {
            DialogHost.Show(new DialogERR("Ошибка"));
        }
    }
}
