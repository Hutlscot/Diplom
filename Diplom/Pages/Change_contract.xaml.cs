using System.Windows;
using System.Windows.Controls;
namespace Diplom
{
    /// <summary>
    /// Interaction logic for Change_contract.xaml
    /// </summary>
    public partial class Change_contract : Page
    {
        ConnectionEntity dbContext = new ConnectionEntity();
        public Change_contract(Student student)
        {
            InitializeComponent();
            DataContext = dbContext.Students.Find(student.Id);
            dbContext.Students.Attach(DataContext as Student);
            cmb_room.ItemsSource = Generation_room.Generation();
        }
        private void btm_save_Click(object sender, RoutedEventArgs e)
        {
            if(Validation())
            {
                (DataContext as Student).Contract.RoomId = (cmb_room.SelectedItem as Room).Id;
                dbContext.SaveChanges();
                Transfer.Trans("Список студентов");
            }
        }
        private bool Validation()
        {
            if (Date_End.SelectedDate == null || Date_Start.SelectedDate == null)
            {
                Dialog_message.MessageER("Неверные\nданные");
                return false;
            }
            if (Val.Val_cmb(cmb_room))
            {
                return false;
            }
            else
            {
                Dialog_message.MessageOK("Сохранено");
                return true;
            }
        }
    }
}
