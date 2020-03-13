using Diplom.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;
using System.Windows;

namespace Diplom
{
    public static class Transfer
    {
        static private int GoOver = 0;
        static private Student st;
        //пользователь при авторизации
        static public User user;
        //таймер для анимации
        static private DispatcherTimer timer = new DispatcherTimer();
        //название страницы
        static private string name_page;
        static public void Initialization()
        {
            timer.Tick += new EventHandler(TimerStart);
            timer.Interval = new TimeSpan(0, 0, 0, 0, 500);
        }
        //метод для перехода
        public static void Add(string name, Student student)
        {
            st = student;
            name_page = name;
            timer.Start();
        }
        public static void Change_student(string name, Student student)
        {
            st = student;
            name_page = name;
            timer.Start();
        }
        public static void Trans(string name)
        {
            name_page = name;
            if (name == "Список студентов"|| name == "Список родственников" || name == "Список комнат")
            {
                Dialog_message.MessageProgress("Загрузка");
                timer.Interval = new TimeSpan(0, 0, 0, 0, 1000);
            }
            timer.Start();
        }
        //метод в таймере
        static private void TimerStart(object sender, EventArgs e)
        {
            GoOver++;
            if (GoOver == 1) 
            {
                switch (name_page)
                {
                    case "Главная":
                        Manager_frame.frame.Navigate(new Main_page());
                        break;
                    case "Добавить студента":
                        Manager_frame.frame.Navigate(new Add_person());
                        break;
                    case "Добавить представителя":
                        Manager_frame.frame.Navigate(new Add_representative_and_pasport(st));
                        break;
                    case "Добавить родственников":
                        Manager_frame.frame.Navigate(new Add_relative(st));
                        break;
                    case "Добавить договор":
                        Manager_frame.frame.Navigate(new Add_contract(st));
                        break;
                    case "Список студентов":
                        Manager_frame.frame.Navigate(new List_students());
                        break;
                    case "Список родственников":
                        Manager_frame.frame.Navigate(new List_relatives());
                        break;
                    case "Редактировать студента":
                        Manager_frame.frame.Navigate(new Add_person());
                        break;
                    case "Список комнат":
                        Manager_frame.frame.Navigate(new List_rooms());
                        break;
                    case "Добавить комнату":
                        Manager_frame.frame.Navigate(new Add_room());
                        break;
                    case "Управление документацией":
                        Manager_frame.frame.Navigate(new List_contracts());
                        break;
                    case "Данные администратора":
                        Manager_frame.frame.Navigate(new Page_admin());
                        break;
                    case "Добавить пользователя":
                        Manager_frame.frame.Navigate(new Add_user());
                        break;
                    case "Список пользователей":
                        Manager_frame.frame.Navigate(new List_users());
                        break;
                }
            }
            TimerStop(timer);
        }
        //остановка таймера
        static private void TimerStop(DispatcherTimer timer)
        {
            timer.Stop();
            GoOver = 0;
        }
    }
}
