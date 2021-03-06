﻿
using Microsoft.Win32;
using System.IO;
using System.Windows;
using System.Windows.Controls;
namespace Diplom
{
    /// <summary>
    /// Interaction logic for Add_person.xaml
    /// </summary>
    public partial class Add_person : Page
    {
        byte[] img;
        public Add_person()
        {
            InitializeComponent();
            txt_phone.PreviewTextInput += Val.Phone_PreviewTextInput;
            txt_series.PreviewTextInput += Val.Series_PreviewTextInput;
            txt_number.PreviewTextInput += Val.Number_PreviewTextInput;
            txt_division_code.PreviewTextInput += Val.Code_PreviewTextInput;
        }
        //добавление в бд
        private void btm_next_Click(object sender, RoutedEventArgs e)
        {
            if (Validation())
            {
                ConnectionEntity dbContex = new ConnectionEntity();
                Person man = new Person();
                man.Type = "Студент";
                man.LastName = txt_surname.Text;
                man.Name = txt_name.Text;
                man.MiddleName = txt_patronymic.Text;
                man.Phone = txt_phone.Text;
                dbContex.People.Add(man);
                dbContex.SaveChanges();
                Student student = new Student();
                student.Id = man.Id;
                student.DateOfBirth = Date_of_birth.SelectedDate.Value;
                student.Group = txt_group.Text;
                if (img != null)
                {
                    student.Photo = img;
                }
                dbContex.Students.Add(student);
                Pasport pasport = new Pasport();
                pasport.Series = txt_series.Text;
                pasport.Number = txt_number.Text;
                pasport.WhoGave = txt_who_gave.Text;
                pasport.DateGet = Date_of_issue.SelectedDate.Value;
                pasport.Address = txt_address.Text;
                pasport.DevisionCode = txt_division_code.Text;
                pasport.PersonId = man.Id;
                dbContex.Pasports.Add(pasport);
                dbContex.SaveChanges();
                //Student student = new Student { Id = 4 };
                Transfer.Add("Добавить представителя",student);
            }
        }
        //метод для загрузки фото
        private void btm_load_photo_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "PNG Фото (*.png)|*.png|JPG Фото (*.jpg)|*.jpg|JPEG Фото (*.jpeg)|*.jpeg";
            if (openFile.ShowDialog() == true)
            {
                string directory = openFile.FileName;
                img = File.ReadAllBytes(directory);
                Dialog_message.MessageOK("Фото загруженно");
            }
        }
        private bool Validation()
        {
            if (Val.Val_txt(txt_surname) || Val.Val_txt(txt_name) || Val.Val_txt(txt_patronymic) ||
                Val.Val_txt(txt_phone) || Val.Val_txt(txt_group) || Val.Val_txt(txt_series) ||
                Val.Val_txt(txt_number) || Val.Val_txt(txt_who_gave) || Val.Val_txt(txt_address) ||
                Val.Val_txt(txt_division_code) || Date_of_birth.SelectedDate == null || Date_of_issue.SelectedDate == null)
            {
                return false;
            }
            if(Val.Val_Phone(txt_phone))
            {
                return false;
            }
            if(Val.Val_series(txt_series)||Val.Val_number(txt_number)||Val.Val_code(txt_division_code))
            {
                return false;
            }
            Dialog_message.MessageOK("Сохранено");
            return true;
        }
    }
}