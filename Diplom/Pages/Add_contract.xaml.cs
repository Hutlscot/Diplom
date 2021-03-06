﻿using System.Windows;
using System.Windows.Controls;
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
            if (Validation())
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
        private bool Validation()
        {
            if(Date_End.SelectedDate == null || Date_Start.SelectedDate == null)
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
