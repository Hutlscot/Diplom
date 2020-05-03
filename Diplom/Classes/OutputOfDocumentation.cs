using System;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
namespace Diplom
{
    public static class OutputOfDocumentation
    {
        private static string path = Environment.CurrentDirectory+@"\Primer\";
        public static void Contract_1(Contract contract)
        {
            Student student = contract.Student;
            if (!contract.Adult)
            {
                var app = new Word.Application();
                var dogovor = app.Documents.Open(path + "Dog_1_1.docx");
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "Word документ (*.docx)|*.docx";
                save.FileName = "Contract_1.1_№_" + student.Contract.Id;
                DialogResult result = save.ShowDialog();
                if (result == DialogResult.Cancel)
                {
                    return;
                }
                ReplaceWord("{id_contract}", student.Contract.Id.ToString(), dogovor);//номер договора
                ReplaceWord("{date_now}", Format_Date(student.Contract.DateStart), dogovor);
                ReplaceWord("{FIO_representative}", student.Representative.Person.LastName + " "
                    + student.Representative.Person.Name + " " + student.Representative.Person.MiddleName, dogovor);
                ReplaceWord("{FIO_student}", student.Person.LastName + " " + student.Person.Name +
                    " " + student.Person.MiddleName, dogovor);
                ReplaceWord("{number_room}", student.Contract.Room.Number.ToString(), dogovor);
                //ReplaceWord("{tech_pasport}", student.Contract.Room.TechPasport, dogovor);
                ReplaceWord("{area_room}", student.Contract.Room.Area.ToString(), dogovor);

                ReplaceWord("{date_start}", Format_Date(student.Contract.DateStart), dogovor);
                ReplaceWord("{date_end}", Format_Date(student.Contract.DateEnd), dogovor);
                //первая оплата полугодие
                ReplaceWord("{date_start}", Format_Date(student.Contract.DateStart), dogovor);
                ReplaceWord("{date_end}", Format_Date(student.Contract.DateEnd), dogovor);
                //вторая оплата полугодие
                ReplaceWord("{date_start}", Format_Date(student.Contract.DateStart), dogovor);
                ReplaceWord("{date_end}", Format_Date(student.Contract.DateEnd), dogovor);
                //данные представителя
                ReplaceWord("{Last_name_rep}", student.Representative.Person.LastName, dogovor);
                ReplaceWord("{Name_rep}", student.Representative.Person.Name, dogovor);
                ReplaceWord("{middle_name_rep}", student.Representative.Person.MiddleName, dogovor);
                ReplaceWord("{series_rep}", student.Representative.Person.Pasport.Series, dogovor);
                ReplaceWord("{number_rep}", student.Representative.Person.Pasport.Number, dogovor);
                ReplaceWord("{who_give_rep}", student.Representative.Person.Pasport.WhoGave, dogovor);
                ReplaceWord("{date_give_rep}", Format_Date(student.Representative.Person.Pasport.DateGet), dogovor);
                ReplaceWord("{address_rep}", student.Representative.Person.Pasport.Address, dogovor);
                ReplaceWord("{phone_rep}", student.Representative.Person.Phone, dogovor);
                //данные студента
                ReplaceWord("{Last_name_stud}", student.Person.LastName, dogovor);
                ReplaceWord("{Name_stud}", student.Person.Name, dogovor);
                ReplaceWord("{middle_name_stud}", student.Person.MiddleName, dogovor);
                ReplaceWord("{series_stud}", student.Person.Pasport.Series, dogovor);
                ReplaceWord("{number_stud}", student.Person.Pasport.Number, dogovor);
                ReplaceWord("{who_give_stud}", student.Person.Pasport.WhoGave, dogovor);
                ReplaceWord("{date_give_stud}", Format_Date(student.Person.Pasport.DateGet), dogovor);
                ReplaceWord("{address_stud}", student.Person.Pasport.Address, dogovor);
                ReplaceWord("{phone_stud}", student.Person.Phone, dogovor);

                dogovor.SaveAs(save.FileName);
                dogovor.Close();
                app.Quit();
            }
            else
            {
                var app = new Word.Application();
                var dogovor = app.Documents.Open(path + "Dog_1_2.docx");
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "Word документ (*.docx)|*.docx";
                save.FileName = "Contract_1.2_№_" + student.Contract.Id;
                DialogResult result = save.ShowDialog();
                if (result == DialogResult.Cancel)
                {
                    return;
                }
                ReplaceWord("{id_contract}", student.Contract.Id.ToString(), dogovor);//номер договора
                ReplaceWord("{date_now}", Format_Date(student.Contract.DateStart), dogovor);
                ReplaceWord("{FIO_student}", student.Person.LastName + " " + student.Person.Name +
                    " " + student.Person.MiddleName, dogovor);
                ReplaceWord("{number_room}", student.Contract.Room.Number.ToString(), dogovor);
                //ReplaceWord("{tech_pasport}", student.Contract.Room.TechPasport, dogovor);
                ReplaceWord("{area_room}", student.Contract.Room.Area.ToString(), dogovor);

                ReplaceWord("{date_start}", Format_Date(student.Contract.DateStart), dogovor);
                ReplaceWord("{date_end}", Format_Date(student.Contract.DateEnd), dogovor);
                //первая оплата полугодие
                ReplaceWord("{date_start}", Format_Date(student.Contract.DateStart), dogovor);
                ReplaceWord("{date_end}", Format_Date(student.Contract.DateEnd), dogovor);
                //вторая оплата полугодие
                ReplaceWord("{date_start}", Format_Date(student.Contract.DateStart), dogovor);
                ReplaceWord("{date_end}", Format_Date(student.Contract.DateEnd), dogovor);
                //данные студента
                ReplaceWord("{Last_name_stud}", student.Person.LastName, dogovor);
                ReplaceWord("{Name_stud}", student.Person.Name, dogovor);
                ReplaceWord("{middle_name_stud}", student.Person.MiddleName, dogovor);
                ReplaceWord("{series_stud}", student.Person.Pasport.Series, dogovor);
                ReplaceWord("{number_stud}", student.Person.Pasport.Number, dogovor);
                ReplaceWord("{who_give_stud}", student.Person.Pasport.WhoGave, dogovor);
                ReplaceWord("{date_give_stud}", Format_Date(student.Person.Pasport.DateGet), dogovor);
                ReplaceWord("{address_stud}", student.Person.Pasport.Address, dogovor);
                ReplaceWord("{phone_stud}", student.Person.Phone, dogovor);
                
                dogovor.SaveAs(save.FileName);
                dogovor.Close();
                app.Quit();
            }
        }
        public static void Contract_2(Contract contract)
        {
            Student student = contract.Student;
            var app = new Word.Application();
            var dogovor = app.Documents.Open(path + "Dog_2.docx");
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Word документ (*.docx)|*.docx";
            save.FileName = "Contract_2_№_" + student.Contract.Id;
            DialogResult result = save.ShowDialog();
            if (result == DialogResult.Cancel)
            {
                return;
            }
            ReplaceWord("{id_contract}", student.Contract.Id.ToString(), dogovor);//номер договора
            ReplaceWord("{date_start}", Format_Date(student.Contract.DateStart), dogovor);
            ReplaceWord("{date_now}", Format_Date(student.Contract.DateStart), dogovor);
            ReplaceWord("{FIO_student}", student.Person.LastName + " " + student.Person.Name +
                " " + student.Person.MiddleName, dogovor);
            ReplaceWord("{FIO_representative}", student.Representative.Person.LastName + " "
                    + student.Representative.Person.Name + " " + student.Representative.Person.MiddleName, dogovor);
            ReplaceWord("{id_contract}", student.Contract.Id.ToString(), dogovor);
            ReplaceWord("{date_start}", Format_Date(student.Contract.DateStart), dogovor);
            ReplaceWord("{number_room}", student.Contract.Room.Number.ToString(), dogovor);
            //ReplaceWord("{tech_pasport}", student.Contract.Room.TechPasport, dogovor);
            ReplaceWord("{area_room}", student.Contract.Room.Area.ToString(), dogovor);

            ReplaceWord("{date_start}", Format_Date(student.Contract.DateStart), dogovor);
            ReplaceWord("{date_end}", Format_Date(student.Contract.DateEnd), dogovor);
            //данные студента
            ReplaceWord("{Last_name_stud}", student.Person.LastName, dogovor);
            ReplaceWord("{Name_stud}", student.Person.Name, dogovor);
            ReplaceWord("{middle_name_stud}", student.Person.MiddleName, dogovor);
            ReplaceWord("{series_stud}", student.Person.Pasport.Series, dogovor);
            ReplaceWord("{number_stud}", student.Person.Pasport.Number, dogovor);
            ReplaceWord("{who_give_stud}", student.Person.Pasport.WhoGave, dogovor);
            ReplaceWord("{date_give_stud}", Format_Date(student.Person.Pasport.DateGet), dogovor);
            ReplaceWord("{address_stud}", student.Person.Pasport.Address, dogovor);
            ReplaceWord("{phone_stud}", student.Person.Phone, dogovor);
            //данные представителя
            ReplaceWord("{Last_name_rep}", student.Representative.Person.LastName, dogovor);
            ReplaceWord("{Name_rep}", student.Representative.Person.Name, dogovor);
            ReplaceWord("{middle_name_rep}", student.Representative.Person.MiddleName, dogovor);
            ReplaceWord("{series_rep}", student.Representative.Person.Pasport.Series, dogovor);
            ReplaceWord("{number_rep}", student.Representative.Person.Pasport.Number, dogovor);
            ReplaceWord("{who_give_rep}", student.Representative.Person.Pasport.WhoGave, dogovor);
            ReplaceWord("{date_give_rep}", Format_Date(student.Representative.Person.Pasport.DateGet), dogovor);
            ReplaceWord("{address_rep}", student.Representative.Person.Pasport.Address, dogovor);
            ReplaceWord("{phone_rep}", student.Representative.Person.Phone, dogovor);

            dogovor.SaveAs(save.FileName);
            dogovor.Close();
            app.Quit();
        }
        public static void Anketa_student(Contract contract)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Excel документ (*.xlsx)|*.xlsx";
            save.FileName = "Anketa_student_number_" + contract.Student.Id;
            save.ShowDialog();
        }
        //method replace in word
        private static void ReplaceWord(string name, string value, Word.Document document)
        {
            Word.Range range = document.Content;
            range.Find.ClearFormatting();
            range.Find.Execute(FindText: name, ReplaceWith: value);
        }
        private static string Format_Date(DateTime dat)
        {
            return " «" + dat.Day.ToString() + "» "+ string.Format("{0:Y}", dat);
        }
    }
}
