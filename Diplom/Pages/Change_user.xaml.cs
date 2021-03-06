﻿using System.Windows;
using System.Windows.Controls;
namespace Diplom
{
    /// <summary>
    /// Interaction logic for Change_user.xaml
    /// </summary>
    public partial class Change_user : Page
    {
        ConnectionEntity dbContext = new ConnectionEntity();
        public Change_user(User user)
        {
            InitializeComponent();
            DataContext = dbContext.Users.Find(user.Id);
            dbContext.Users.Attach(DataContext as User);
            (DataContext as User).Password = "";
        }
        private void btm_create_Click(object sender, RoutedEventArgs e)
        {
            if(Validation())
            {
                string password = Cryptographer.Coding(txt_password.Text);
                (DataContext as User).Password = password;
                dbContext.SaveChanges();
                
                Transfer.Trans("Список пользователей");
            }
        }
        private bool Validation()
        {
            if (Val.Val_txt(txt_name) || Val.Val_txt(txt_surname) || Val.Val_txt(txt_patronymic)
                || Val.Val_txt(txt_login) || Val.Val_txt(txt_password) || Val.Val_cmb(cmb_type))
            {
                return false;
            }
            if (txt_login.Text.Length < 5 || txt_password.Text.Length < 8)
            {
                Dialog_message.MessageER("Некорретные\nданные");
                return false;
            }
            Dialog_message.MessageOK("Сохранено");
            return true;
        }
    }
}
