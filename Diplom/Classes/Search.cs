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
        static public List<Student> Find_Student(List<Student> students,string text, DatePicker date)
        {
            if (date.SelectedDate != null)
            {
                 return students.Where(x => x.Person.LastName.ToLower().Contains(text.ToLower()) && x.Contracts.FirstOrDefault().DateStart > date.SelectedDate.Value).ToList();
            }
            return students.Where(x => x.Person.LastName.ToLower().Contains(text.ToLower())).ToList();
        }
    }
}
