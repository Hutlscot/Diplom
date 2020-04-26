using System;
using System.Windows;
using System.Windows.Controls;
namespace Diplom
{
    /// <summary>
    /// Interaction logic for Add_room.xaml
    /// </summary>
    public partial class Add_room : Page
    {
        public Add_room()
        {
            InitializeComponent();
            txt_number.TextChanged += Val.Number_room_TextChanged;
            txt_pasport.PreviewTextInput += Val.Number_PreviewTextInput;
            txt_area.TextChanged += Val.Number_room_TextChanged;
            txt_number_of_place.PreviewTextInput += Val.Number_PreviewTextInput;
        }
        private void btm_add_contract_Click(object sender, RoutedEventArgs e)
        {
            if(Validation())
            {
                using (ConnectionEntity dbContext= new ConnectionEntity())
                {
                    Room room = new Room();
                    room.Number = Convert.ToDouble(txt_number.Text);
                    room.TechPasport = txt_pasport.Text;
                    room.Area = Convert.ToDouble(txt_pasport.Text);
                    room.NumberOfPlace = Convert.ToInt32(txt_number_of_place.Text);
                    dbContext.Rooms.Add(room);
                    dbContext.SaveChanges();
                    Transfer.Trans("Добавить комнату");
                }
            }
        }
        private bool Validation()
        {
            if (Val.Val_txt(txt_number) || Val.Val_txt(txt_pasport) || Val.Val_txt(txt_area) ||
                Val.Val_txt(txt_number_of_place))
            {
                return false;
            }
            Dialog_message.MessageOK("Сохранено");
            return true;
        }
    }
}
