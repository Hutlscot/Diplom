using System.Windows.Forms;
namespace Diplom
{
    public static class OutputOfDocumentation
    {
        public static void Contract_1(Student student)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter= "Word документ (*.docx)|*.docx";
            save.FileName = "Contract_1_student_number_" + student.Id;
            save.ShowDialog();
        }
        public static void Contract_2(Student student)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Word документ (*.docx)|*.docx";
            save.FileName = "Contract_2_student_number_" + student.Id;
            save.ShowDialog();
        }
        public static void Anketa_student(Student student)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Excel документ (*.xlsx)|*.xlsx";
            save.FileName = "Anketa_student_number_" + student.Id;
            save.ShowDialog();
        }
    }
}
