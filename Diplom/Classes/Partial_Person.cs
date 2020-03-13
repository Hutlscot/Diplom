using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom
{
    partial class Person
    {
        //ФИО для родственников
        public string FIO
        {
            get
            {
                return LastName + " " + Name[0] + ". " + MiddleName[0]+".";
            }
            set
            {
                this.FIO = FIO;
            }
        }
        public string Name_Patronymic
        {
            get
            {
                return Name + " " + MiddleName;
            }
            set
            {
                this.Name_Patronymic = Name_Patronymic;
            }
        }
        public Pasport Pasport
        {
            get
            {
                return Pasports.FirstOrDefault();
            }
            set
            {

            }
        }
    }
}
