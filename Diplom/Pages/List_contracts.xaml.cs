﻿using System.Linq;
using System.Windows;
using System.Windows.Controls;
namespace Diplom
{
    /// <summary>
    /// Interaction logic for List_contracts.xaml
    /// </summary>
    public partial class List_contracts : Page
    {
        ConnectionEntity dbContext = new ConnectionEntity();
        Contract contract_selected = new Contract();
        public List_contracts()
        {
            InitializeComponent();
            list.ItemsSource = dbContext.Contracts.ToList();
        }
        private void list_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            contract_selected = list.SelectedItem as Contract;
        }
        private void btm_contract_1_Click(object sender, RoutedEventArgs e)
        {
            OutputOfDocumentation.Contract_1(contract_selected);
        }
        private void btm_contract_2_Click(object sender, RoutedEventArgs e)
        {
            OutputOfDocumentation.Contract_2(contract_selected);
        }
        private void btm_form_Click(object sender, RoutedEventArgs e)
        {
            OutputOfDocumentation.Anketa_student(contract_selected);
        }
        private void btm_delete_Click(object sender, RoutedEventArgs e)
        {
            text_message.Text = "Удалить\nдоговор № " + contract_selected.Id;
            Warning.IsOpen = true;
        }
        private void btm_OK_Click(object sender, RoutedEventArgs e)
        {
            dbContext.Contracts.Remove(dbContext.Contracts.Find(contract_selected.Id));
            dbContext.SaveChanges();
            list.ItemsSource = dbContext.Contracts.ToList();
        }
        private void txt_fio_TextChanged(object sender, TextChangedEventArgs e)
        {
            list.ItemsSource = Search.Find_Contract(txt_fio.Text, Date_End);
        }
        private void Date_End_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            list.ItemsSource = Search.Find_Contract(txt_fio.Text, Date_End);
        }
    }
}
