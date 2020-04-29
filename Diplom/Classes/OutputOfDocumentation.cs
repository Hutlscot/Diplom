using System;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
namespace Diplom
{
    public static class OutputOfDocumentation
    {
        private static string path = Environment.CurrentDirectory+@"\Primer\";
        public static void Contract_1(Student student)
        {
            var app = new Word.Application();
            var dogovor = app.Documents.Open(path + "Dog_1_1.docx");
            SaveFileDialog save = new SaveFileDialog();
            save.Filter= "Word документ (*.docx)|*.docx";
            save.FileName = "Contract_1_№_" + student.Contract.Id;
            DialogResult result = save.ShowDialog();
            if(result==DialogResult.Cancel)
            {
                return;
            }
            ReplaceWord("{id_contract}", student.Contract.Id.ToString(), dogovor);//номер договора
            ReplaceWord("{day_now}", student.Contract.DateStart.Day.ToString(), dogovor);
            ReplaceWord("{month_now}", Month(student.Contract.DateStart), dogovor);
            ReplaceWord("{year_now}", student.Contract.DateStart.Year.ToString(), dogovor);
            ReplaceWord("{FIO_representative}", student.Representative.Person.LastName+" "
                + student.Representative.Person.Name + " "+ student.Representative.Person.MiddleName, dogovor);
            ReplaceWord("{FIO_student}", student.Person.LastName+" "+student.Person.Name+
                " "+student.Person.MiddleName, dogovor);
            ReplaceWord("{number_room}", student.Contract.Room.Number.ToString(), dogovor);
            //ReplaceWord("{tech_pasport}", student.Contract.Room.TechPasport, dogovor);
            ReplaceWord("{area_room}", student.Contract.Room.Area.ToString(), dogovor);

            ReplaceWord("{day_start}", student.Contract.DateStart.Day.ToString(), dogovor);
            ReplaceWord("{month_start}", Month(student.Contract.DateStart), dogovor);
            ReplaceWord("{year_start}", student.Contract.DateStart.Year.ToString(), dogovor);
            ReplaceWord("{day_end}", student.Contract.DateEnd.Day.ToString(), dogovor);
            ReplaceWord("{month_end}", Month(student.Contract.DateEnd), dogovor);
            ReplaceWord("{year_end}", student.Contract.DateEnd.Year.ToString(), dogovor);
            //первая оплата
            ReplaceWord("{day_start}", student.Contract.DateStart.Day.ToString(), dogovor);
            ReplaceWord("{month_start}", Month(student.Contract.DateStart), dogovor);
            ReplaceWord("{year_start}", student.Contract.DateStart.Year.ToString(), dogovor);
            ReplaceWord("{day_end}", student.Contract.DateEnd.Day.ToString(), dogovor);
            ReplaceWord("{month_end}", Month(student.Contract.DateEnd), dogovor);
            ReplaceWord("{year_end}", student.Contract.DateEnd.Year.ToString(), dogovor);
            //вторая оплата
            ReplaceWord("{day_start}", student.Contract.DateStart.Day.ToString(), dogovor);
            ReplaceWord("{month_start}", Month(student.Contract.DateStart), dogovor);
            ReplaceWord("{year_start}", student.Contract.DateStart.Year.ToString(), dogovor);
            ReplaceWord("{day_end}", student.Contract.DateEnd.Day.ToString(), dogovor);
            ReplaceWord("{month_end}", Month(student.Contract.DateEnd), dogovor);
            ReplaceWord("{year_end}", student.Contract.DateEnd.Year.ToString(), dogovor);
            //данные представителя
            ReplaceWord("{Last_name_rep}", student.Representative.Person.LastName, dogovor);
            ReplaceWord("{Name_rep}", student.Representative.Person.Name, dogovor);
            ReplaceWord("{middle_name_rep}", student.Representative.Person.MiddleName, dogovor);
            ReplaceWord("{series_rep}", student.Representative.Person.Pasport.Series, dogovor);
            ReplaceWord("{number_rep}", student.Representative.Person.Pasport.Number, dogovor);
            ReplaceWord("{who_give_rep}", student.Representative.Person.Pasport.WhoGave, dogovor);
            ReplaceWord("{date_give_rep}", student.Representative.Person.Pasport.DateGet.ToShortDateString(), dogovor);
            ReplaceWord("{address_rep}", student.Representative.Person.Pasport.Address, dogovor);
            ReplaceWord("{phone_rep}", student.Representative.Person.Phone, dogovor);
            //ReplaceWord("{id_contract}", student.Contract.Id.ToString(), dogovor);
            //ReplaceWord("{id_contract}", student.Contract.Id.ToString(), dogovor);
            //ReplaceWord("{id_contract}", student.Contract.Id.ToString(), dogovor);
            //ReplaceWord("{id_contract}", student.Contract.Id.ToString(), dogovor);
            //ReplaceWord("{id_contract}", student.Contract.Id.ToString(), dogovor);
            //ReplaceWord("{id_contract}", student.Contract.Id.ToString(), dogovor);
            //ReplaceWord("{id_contract}", student.Contract.Id.ToString(), dogovor);

            dogovor.SaveAs(save.FileName);
            dogovor.Close();
            app.Quit();

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
        //method replace in word
        private static void ReplaceWord(string name, string value, Word.Document document)
        {
            Word.Range range = document.Content;
            range.Find.ClearFormatting();
            range.Find.Execute(FindText: name, ReplaceWith: value);
        }
        private static string Month(DateTime date)
        {
            string s = date.Month.ToString();
            if(s.Length<2)
            {
                return "0" + s;
            }
            return s;
        }
    }
}
