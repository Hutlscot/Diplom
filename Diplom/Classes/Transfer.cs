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
        static int GoOver = 0;
        //таймер для анимации
        static DispatcherTimer timer = new DispatcherTimer();
        //название страницы
        static public string name_page;
        static public void Initialization()
        {
            timer.Tick += new EventHandler(TimerStart);
            timer.Interval = new TimeSpan(0, 0, 0, 0, 500);
        }
        //метод для перехода
        public static void Trans(string name)
        {
            name_page = name;
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
                        Manager_frame.frame.Navigate(new Add_representative_and_pasport());
                        break;
                    case "Добавить родственников":
                        Manager_frame.frame.Navigate(new Add_relative());
                        break;
                    case "Список студентов":
                        Manager_frame.frame.Navigate(new List_students());
                        break;
                }
            }
            TimerStop();
        }
        //остановка таймера
        static private void TimerStop()
        {
            timer.Stop();
            GoOver = 0;
        }
    }
}
