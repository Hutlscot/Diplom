using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Diplom
{
    static class Search
    {
        private static ConnectionEntity dbContext = new ConnectionEntity();
        public static List<Student> Find_Student(string surname, DatePicker date)
        {
            if (string.IsNullOrEmpty(surname))
            {
                if (date.SelectedDate == null)
                {
                    return dbContext.Students.ToList(); 
                }
                else return dbContext.Students.Where(x =>x.Contracts.FirstOrDefault().DateStart > date.SelectedDate.Value).ToList();
            }
            else
            {
                if (date.SelectedDate == null)
                {
                    return dbContext.Students.Where(x => x.Person.LastName.ToLower().Contains(surname.ToLower())).ToList();
                }
                else return dbContext.Students.Where(x => x.Person.LastName.ToLower().Contains(surname.ToLower()) && x.Contracts.FirstOrDefault().DateStart > date.SelectedDate.Value).ToList();
            }
        }
        public static List<User> Find_user(string surname)
        {
            if (!string.IsNullOrEmpty(surname))
            {
                return dbContext.Users.Where(x =>x.Person.LastName.ToLower().Contains(surname.ToLower())).ToList();
            }
            else return dbContext.Users.ToList();
        }
    }
}
