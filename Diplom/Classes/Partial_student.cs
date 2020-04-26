using System.Linq;
namespace Diplom
{
    partial class Student
    {
        //Номер комнаты студента
        public double Room_number
        {
            get
            {
                Contract contract = Contracts.FirstOrDefault();
                foreach (var c in Contracts)
                {
                    if (c.DateEnd > contract.DateEnd)
                    {
                        contract = c;
                    }
                }
                if (contract == null)
                {
                    return 0;
                }
                return contract.Room.Number;
            }
            set
            {
                this.Room_number = Room_number;
            }
        }
        //имя, отчество и телефон представителя
        public string Name_rep_and_phone
        {
            get
            {
                if(Representatives.FirstOrDefault()==null)
                {
                    return "";
                }
                Representative rep = Representatives.FirstOrDefault();
                return rep.Person.Name+" "+rep.Person.MiddleName+"\n"+rep.Person.Phone;
            }
            set
            {
                this.Name_rep_and_phone = Name_rep_and_phone;
            }
        }
        public Representative Representative
        {
            get
            {
                return Representatives.FirstOrDefault();
            }
            set { }
        }
        public Contract Contract
        {
            get
            {
                return Contracts.FirstOrDefault();
            }
            set { }
        }
    }
}
