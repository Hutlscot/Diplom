﻿using System;
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
    /// Interaction logic for Add_person.xaml
    /// </summary>
    public partial class Add_person : Page
    {
        public Add_person()
        {
            InitializeComponent();
        }
        private void txt_phone_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !(Char.IsDigit(e.Text, 0));
            Validation_phone();
        }
        private void Validation_phone()
        {
            if (txt_phone.Text.Length == 1)
            {
                txt_phone.Text = '+' + txt_phone.Text;
            }
            if (txt_phone.Text.Length == 2)
            {
                txt_phone.Text += '(';
            }
            if (txt_phone.Text.Length == 6)
            {
                txt_phone.Text += ")-";
            }
            if (txt_phone.Text.Length == 11)
            {
                txt_phone.Text += '-';
            }
            if (txt_phone.Text.Length == 14)
            {
                txt_phone.Text += '-';
            }
            txt_phone.SelectionStart = txt_phone.Text.Length;
        }
        private void txt_series_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !(Char.IsDigit(e.Text, 0));
            if (txt_series.Text.Length == 2)
            {
                txt_series.Text += ' ';
            }
            txt_series.SelectionStart = txt_series.Text.Length;
        }
        private void txt_division_code_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !(Char.IsDigit(e.Text, 0));
            if (txt_division_code.Text.Length == 3)
            {
                txt_division_code.Text += '-';
            }
            txt_division_code.SelectionStart = txt_division_code.Text.Length;
        }
        private void txt_number_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !(Char.IsDigit(e.Text, 0));
        }

        private void btm_next_Click(object sender, RoutedEventArgs e)
        {
            Manager_frame.frame.Navigate(new Add_representative_and_pasport());
        }
    }
}