using System;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using Excel = Microsoft.Office.Interop.Excel;
using System.Collections.Generic;
using System.Linq;

namespace Diplom
{
    public static class OutputOfDocumentation
    {
        private static string path = Environment.CurrentDirectory+@"\Primer\";
        public static void Contract_1(Contract contract)
        {
            var app = new Word.Application();
            if (!contract.Adult)
            {
                var dogovor = app.Documents.Open(path + "Dog_1_1.docx");
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "Word документ (*.docx)|*.docx";
                save.FileName = "Contract_1_1_№_" + contract.Id;
                DialogResult result = save.ShowDialog();
                if (result == DialogResult.Cancel)
                {
                    return;
                }
                ReplaceWord("{id_contract}", contract.Id.ToString(), dogovor);//номер договора
                ReplaceWord("{date_now}", Format_Date(contract.DateStart), dogovor);
                ReplaceWord("{FIO_representative}", contract.Student.Representative.Person.LastName + " "
                    + contract.Student.Representative.Person.Name + " " + contract.Student.Representative.Person.MiddleName, dogovor);
                ReplaceWord("{FIO_student}", contract.Student.Person.LastName + " " + contract.Student.Person.Name +
                    " " + contract.Student.Person.MiddleName, dogovor);
                ReplaceWord("{number_room}", contract.Room.Number.ToString(), dogovor);
                //ReplaceWord("{tech_pasport}", student.Contract.Room.TechPasport, dogovor);
                ReplaceWord("{area_room}", contract.Room.Area.ToString(), dogovor);

                ReplaceWord("{date_start}", Format_Date(contract.DateStart), dogovor);
                ReplaceWord("{date_end}", Format_Date(contract.DateEnd), dogovor);
                //первая оплата полугодие
                ReplaceWord("{date_start}", Format_Date(contract.DateStart), dogovor);
                ReplaceWord("{date_end}", Format_Date(contract.DateEnd), dogovor);
                //вторая оплата полугодие
                ReplaceWord("{date_start}", Format_Date(contract.DateStart), dogovor);
                ReplaceWord("{date_end}", Format_Date(contract.DateEnd), dogovor);
                //данные представителя
                ReplaceWord("{Last_name_rep}", contract.Student.Representative.Person.LastName, dogovor);
                ReplaceWord("{Name_rep}", contract.Student.Representative.Person.Name, dogovor);
                ReplaceWord("{middle_name_rep}", contract.Student.Representative.Person.MiddleName, dogovor);
                ReplaceWord("{series_rep}", contract.Student.Representative.Person.Pasport.Series, dogovor);
                ReplaceWord("{number_rep}", contract.Student.Representative.Person.Pasport.Number, dogovor);
                ReplaceWord("{who_give_rep}", contract.Student.Representative.Person.Pasport.WhoGave, dogovor);
                ReplaceWord("{date_give_rep}", Format_Date(contract.Student.Representative.Person.Pasport.DateGet), dogovor);
                ReplaceWord("{address_rep}", contract.Student.Representative.Person.Pasport.Address, dogovor);
                ReplaceWord("{phone_rep}", contract.Student.Representative.Person.Phone, dogovor);
                //данные студента
                ReplaceWord("{Last_name_stud}", contract.Student.Person.LastName, dogovor);
                ReplaceWord("{Name_stud}", contract.Student.Person.Name, dogovor);
                ReplaceWord("{middle_name_stud}", contract.Student.Person.MiddleName, dogovor);
                ReplaceWord("{series_stud}", contract.Student.Person.Pasport.Series, dogovor);
                ReplaceWord("{number_stud}", contract.Student.Person.Pasport.Number, dogovor);
                ReplaceWord("{who_give_stud}", contract.Student.Person.Pasport.WhoGave, dogovor);
                ReplaceWord("{date_give_stud}", Format_Date(contract.Student.Person.Pasport.DateGet), dogovor);
                ReplaceWord("{address_stud}", contract.Student.Person.Pasport.Address, dogovor);
                ReplaceWord("{phone_stud}", contract.Student.Person.Phone, dogovor);

                dogovor.SaveAs(save.FileName);
                dogovor.Close();
            }
            else
            {
                var dogovor = app.Documents.Open(path + "Dog_1_2.docx");
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "Word документ (*.docx)|*.docx";
                save.FileName = "Contract_1_2_№_" + contract.Id;
                DialogResult result = save.ShowDialog();
                if (result == DialogResult.Cancel)
                {
                    return;
                }
                ReplaceWord("{id_contract}", contract.Id.ToString(), dogovor);//номер договора
                ReplaceWord("{date_now}", Format_Date(contract.DateStart), dogovor);
                ReplaceWord("{FIO_student}", contract.Student.Person.LastName + " " + contract.Student.Person.Name +
                    " " + contract.Student.Person.MiddleName, dogovor);
                ReplaceWord("{number_room}", contract.Student.Contract.Room.Number.ToString(), dogovor);
                //ReplaceWord("{tech_pasport}", student.Contract.Room.TechPasport, dogovor);
                ReplaceWord("{area_room}", contract.Room.Area.ToString(), dogovor);

                ReplaceWord("{date_start}", Format_Date(contract.DateStart), dogovor);
                ReplaceWord("{date_end}", Format_Date(contract.DateEnd), dogovor);
                //первая оплата полугодие
                ReplaceWord("{date_start}", Format_Date(contract.DateStart), dogovor);
                ReplaceWord("{date_end}", Format_Date(contract.DateEnd), dogovor);
                //вторая оплата полугодие
                ReplaceWord("{date_start}", Format_Date(contract.DateStart), dogovor);
                ReplaceWord("{date_end}", Format_Date(contract.DateEnd), dogovor);
                //данные студента
                ReplaceWord("{Last_name_stud}", contract.Student.Person.LastName, dogovor);
                ReplaceWord("{Name_stud}", contract.Student.Person.Name, dogovor);
                ReplaceWord("{middle_name_stud}", contract.Student.Person.MiddleName, dogovor);
                ReplaceWord("{series_stud}", contract.Student.Person.Pasport.Series, dogovor);
                ReplaceWord("{number_stud}", contract.Student.Person.Pasport.Number, dogovor);
                ReplaceWord("{who_give_stud}", contract.Student.Person.Pasport.WhoGave, dogovor);
                ReplaceWord("{date_give_stud}", Format_Date(contract.Student.Person.Pasport.DateGet), dogovor);
                ReplaceWord("{address_stud}", contract.Student.Person.Pasport.Address, dogovor);
                ReplaceWord("{phone_stud}", contract.Student.Person.Phone, dogovor);
                
                dogovor.SaveAs(save.FileName);
                dogovor.Close();
            }
            app.Quit();
        }
        public static void Contract_2(Contract contract)
        {
            var app = new Word.Application();
            if (!contract.Adult)
            {
                var dogovor = app.Documents.Open(path + "Dog_2_1.docx");
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "Word документ (*.docx)|*.docx";
                save.FileName = "Contract_2_1_№_" + contract.Id;
                DialogResult result = save.ShowDialog();
                if (result == DialogResult.Cancel)
                {
                    return;
                }
                ReplaceWord("{id_contract}", contract.Id.ToString(), dogovor);//номер договора
                ReplaceWord("{date_start}", Format_Date(contract.DateStart), dogovor);
                ReplaceWord("{date_now}", Format_Date(contract.DateStart), dogovor);
                ReplaceWord("{FIO_student}", contract.Student.Person.LastName + " " + contract.Student.Person.Name +
                    " " + contract.Student.Person.MiddleName, dogovor);
                ReplaceWord("{FIO_representative}", contract.Student.Representative.Person.LastName + " "
                        + contract.Student.Representative.Person.Name + " " + contract.Student.Representative.Person.MiddleName, dogovor);
                ReplaceWord("{id_contract}", contract.Student.Contract.Id.ToString(), dogovor);
                ReplaceWord("{date_start}", Format_Date(contract.DateStart), dogovor);
                ReplaceWord("{number_room}", contract.Room.Number.ToString(), dogovor);
                //ReplaceWord("{tech_pasport}", student.Contract.Room.TechPasport, dogovor);
                ReplaceWord("{area_room}", contract.Room.Area.ToString(), dogovor);

                ReplaceWord("{date_start}", Format_Date(contract.DateStart), dogovor);
                ReplaceWord("{date_end}", Format_Date(contract.DateEnd), dogovor);
                //данные студента
                ReplaceWord("{Last_name_stud}", contract.Student.Person.LastName, dogovor);
                ReplaceWord("{Name_stud}", contract.Student.Person.Name, dogovor);
                ReplaceWord("{middle_name_stud}", contract.Student.Person.MiddleName, dogovor);
                ReplaceWord("{series_stud}", contract.Student.Person.Pasport.Series, dogovor);
                ReplaceWord("{number_stud}", contract.Student.Person.Pasport.Number, dogovor);
                ReplaceWord("{who_give_stud}", contract.Student.Person.Pasport.WhoGave, dogovor);
                ReplaceWord("{date_give_stud}", Format_Date(contract.Student.Person.Pasport.DateGet), dogovor);
                ReplaceWord("{address_stud}", contract.Student.Person.Pasport.Address, dogovor);
                ReplaceWord("{phone_stud}", contract.Student.Person.Phone, dogovor);
                //данные представителя
                ReplaceWord("{Last_name_rep}", contract.Student.Representative.Person.LastName, dogovor);
                ReplaceWord("{Name_rep}", contract.Student.Representative.Person.Name, dogovor);
                ReplaceWord("{middle_name_rep}", contract.Student.Representative.Person.MiddleName, dogovor);
                ReplaceWord("{series_rep}", contract.Student.Representative.Person.Pasport.Series, dogovor);
                ReplaceWord("{number_rep}", contract.Student.Representative.Person.Pasport.Number, dogovor);
                ReplaceWord("{who_give_rep}", contract.Student.Representative.Person.Pasport.WhoGave, dogovor);
                ReplaceWord("{date_give_rep}", Format_Date(contract.Student.Representative.Person.Pasport.DateGet), dogovor);
                ReplaceWord("{address_rep}", contract.Student.Representative.Person.Pasport.Address, dogovor);
                ReplaceWord("{phone_rep}", contract.Student.Representative.Person.Phone, dogovor);

                dogovor.SaveAs(save.FileName);
                dogovor.Close();
            }
            else
            {
                var dogovor = app.Documents.Open(path + "Dog_2_2.docx");
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "Word документ (*.docx)|*.docx";
                save.FileName = "Contract_2_2_№_" + contract.Id;
                DialogResult result = save.ShowDialog();
                if (result == DialogResult.Cancel)
                {
                    return;
                }
                ReplaceWord("{id_contract}", contract.Id.ToString(), dogovor);//номер договора
                ReplaceWord("{date_start}", Format_Date(contract.DateStart), dogovor);
                ReplaceWord("{date_now}", Format_Date(contract.DateStart), dogovor);
                ReplaceWord("{FIO_student}", contract.Student.Person.LastName + " " + contract.Student.Person.Name +
                    " " + contract.Student.Person.MiddleName, dogovor);
                ReplaceWord("{FIO_representative}", contract.Student.Representative.Person.LastName + " "
                        + contract.Student.Representative.Person.Name + " " + contract.Student.Representative.Person.MiddleName, dogovor);
                ReplaceWord("{id_contract}", contract.Student.Contract.Id.ToString(), dogovor);
                ReplaceWord("{date_start}", Format_Date(contract.DateStart), dogovor);
                ReplaceWord("{number_room}", contract.Room.Number.ToString(), dogovor);
                //ReplaceWord("{tech_pasport}", student.Contract.Room.TechPasport, dogovor);
                ReplaceWord("{area_room}", contract.Room.Area.ToString(), dogovor);

                ReplaceWord("{date_start}", Format_Date(contract.DateStart), dogovor);
                ReplaceWord("{date_end}", Format_Date(contract.DateEnd), dogovor);
                //данные студента
                ReplaceWord("{Last_name_stud}", contract.Student.Person.LastName, dogovor);
                ReplaceWord("{Name_stud}", contract.Student.Person.Name, dogovor);
                ReplaceWord("{middle_name_stud}", contract.Student.Person.MiddleName, dogovor);
                ReplaceWord("{series_stud}", contract.Student.Person.Pasport.Series, dogovor);
                ReplaceWord("{number_stud}", contract.Student.Person.Pasport.Number, dogovor);
                ReplaceWord("{who_give_stud}", contract.Student.Person.Pasport.WhoGave, dogovor);
                ReplaceWord("{date_give_stud}", Format_Date(contract.Student.Person.Pasport.DateGet), dogovor);
                ReplaceWord("{address_stud}", contract.Student.Person.Pasport.Address, dogovor);
                ReplaceWord("{phone_stud}", contract.Student.Person.Phone, dogovor);

                dogovor.SaveAs(save.FileName);
                dogovor.Close();
            }
            app.Quit();
        }
        public static void Anketa_student(Contract contract)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Excel документ (*.xlsx)|*.xlsx";
            save.FileName = "Anketa_number_" + contract.Id;
            DialogResult result = save.ShowDialog();
            if (result == DialogResult.Cancel)
            {
                return;
            }
            var excelApp = new Excel.Application();
            //excelApp.Visible = true;
            excelApp.Workbooks.Open(@"C:\Users\locadm\Desktop\FINISH (диплом)\Diplom - origin\Diplom\bin\Debug\Primer\Anketa.xlsx");
            Excel._Worksheet worksheet = excelApp.ActiveSheet;
            worksheet.Cells.Replace("{FIO_student}", contract.Student.Person.FIO);
            worksheet.Cells.Replace("{date_of_birth}", Format_Date(contract.Student.DateOfBirth));
            worksheet.Cells.Replace("{group}", contract.Student.Group);
            worksheet.Cells.Replace("{room_number}", contract.Room.Number);
            worksheet.Cells.Replace("{phone_student}", contract.Student.Person.Phone);
            //если представитель отец
            if (contract.Student.Representative.Type1.Name == "Отец")
            {
                worksheet.Cells.Replace("{FIO_father}", contract.Student.Representative.Person.FIO);
                worksheet.Cells.Replace("{place_of_work_fat}", contract.Student.Representative.PlaceOfWork);
                worksheet.Cells.Replace("{phone_rep_fat}", contract.Student.Representative.Person.Phone);
                worksheet.Cells.Replace("{FIO_mother}", "");
                worksheet.Cells.Replace("{place_of_work_mot}", "");
                worksheet.Cells.Replace("{phone_rep_mot}", "");

            }
            //если представитель мать
            if (contract.Student.Representative.Type1.Name == "Мать")
            {
                worksheet.Cells.Replace("{FIO_father}", "");
                worksheet.Cells.Replace("{place_of_work_fat}", "");
                worksheet.Cells.Replace("{phone_rep_fat}", "");
                worksheet.Cells.Replace("{FIO_mother}", contract.Student.Representative.Person.FIO);
                worksheet.Cells.Replace("{place_of_work_mot}", contract.Student.Representative.PlaceOfWork);
                worksheet.Cells.Replace("{phone_rep_mot}", contract.Student.Representative.Person.Phone);
            }
            //если представитель опекун
            if (contract.Student.Representative.Type1.Name == "Опекун")
            {
                worksheet.Cells.Replace("{FIO_father}", "");
                worksheet.Cells.Replace("{place_of_work_fat}", "");
                worksheet.Cells.Replace("{phone_rep_fat}", "");
                worksheet.Cells.Replace("Мать (ФИО)", "Опекун (ФИО)");
                worksheet.Cells.Replace("матери", "опекуна");
                worksheet.Cells.Replace("{FIO_mother}", contract.Student.Representative.Person.FIO);
                worksheet.Cells.Replace("{place_of_work_mot}", contract.Student.Representative.PlaceOfWork);
                worksheet.Cells.Replace("{phone_rep_mot}", contract.Student.Representative.Person.Phone);
            }
            worksheet.Cells.Replace("{residence}", contract.Student.Representative.Residence);
            worksheet.Cells.Replace("{phone_hom}", contract.Student.Representative.HomePhone);

            //цикл для вывода пяти родственников
            List<Relative> relatives = contract.Student.Relatives.ToList();
            for (int x = 0; x < 5; x++)
            {
                if (x < relatives.Count)
                {
                    worksheet.Cells.Replace("{FIO_" + x + "}", relatives[x].Person.FIO);
                    worksheet.Cells.Replace("{phone_" + x + "}", relatives[x].Person.Phone);
                    worksheet.Cells.Replace("{address_" + x + "}", relatives[x].Address);
                }
                else
                {
                    worksheet.Cells.Replace("{FIO_" + x + "}", "");
                    worksheet.Cells.Replace("{phone_" + x + "}", "");
                    worksheet.Cells.Replace("{address_" + x + "}", "");
                }
            }
            //сохранение
            worksheet.SaveAs(save.FileName);
            excelApp.Quit();
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
