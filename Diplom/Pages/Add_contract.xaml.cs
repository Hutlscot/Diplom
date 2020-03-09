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
    /// Interaction logic for Add_contract.xaml
    /// </summary>
    public partial class Add_contract : Page
    {
        Student student;
        public Add_contract(Student student)
        {
            InitializeComponent();
            cmb_room.ItemsSource = Generation_room.Generation();
            this.student = student;
        }

        private void btm_add_contract_Click(object sender, RoutedEventArgs e)
        {
            using (ConnectionEntity dbContext = new ConnectionEntity())
            {
                Contract contract = new Contract();
                contract.DateStart = Date_Start.SelectedDate.Value;
                contract.DateEnd = Date_End.SelectedDate.Value;
                contract.RoomId = (cmb_room.SelectedItem as Room).Id;
                contract.StudentId = student.Id;
                dbContext.Contracts.Add(contract);
                dbContext.SaveChanges();
                Dialog_message.MessageOK("Студент заселен!");
                Transfer.Trans("Добавить студента");
            }
        }
    }
}
