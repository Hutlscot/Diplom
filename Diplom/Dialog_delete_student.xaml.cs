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
    /// Interaction logic for Dialog_delete_user.xaml
    /// </summary>
    public partial class Dialog_delete_student : UserControl
    {
        Student student;
        DataGrid list;
        string fio;
        DatePicker dateEnd;
        ConnectionEntity dbContext = new ConnectionEntity();
        public Dialog_delete_student(Student st, DataGrid list, string fio, DatePicker dateEnd)
        {
            InitializeComponent();
            this.student = dbContext.Students.Find(st.Id);
            this.list = list;
            this.fio = fio;
            this.dateEnd = dateEnd;
            text_message.Text = "Удалить\n" + st.Person.FIO + " ?";
        }
        private void btm_OK_Click(object sender, RoutedEventArgs e)
        {
            int rep = student.Representatives.FirstOrDefault().Person.Id;
            bool x = false;
            int rel = 0;
            if (student.Relatives.FirstOrDefault() != null)
            {
                rel = student.Relatives.FirstOrDefault().Person.Id;
                x = true;
            }
            int stud = student.Person.Id;
            dbContext.Students.Remove(student);
            dbContext.People.Remove(dbContext.People.Find(rep));
            if (x)
            {
                dbContext.People.Remove(dbContext.People.Find(rel));
            }
            dbContext.People.Remove(dbContext.People.Find(stud));
            dbContext.SaveChanges();
            list.ItemsSource = Search.Find_Student(fio, dateEnd);
        }
    }
}
