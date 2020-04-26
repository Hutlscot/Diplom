using System.Linq;
using System.Windows;
using System.Windows.Controls;


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
            bool y = false;
            int rep = 0;
            if (student.Representatives.FirstOrDefault() != null)
            {
                rep = student.Representatives.FirstOrDefault().Person.Id;
                y = true;
            }
            bool x = false;
            int rel = 0;
            if (student.Relatives.FirstOrDefault() != null)
            {
                rel = student.Relatives.FirstOrDefault().Person.Id;
                x = true;
            }
            int stud = student.Person.Id;
            dbContext.Students.Remove(student);
            if(y)
            {
                dbContext.People.Remove(dbContext.People.Find(rep));
            }
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
