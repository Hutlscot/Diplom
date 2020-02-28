using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom
{
    partial class Person
    {
        public string FIO
        {
            get
            {
                return LastName + " " + Name[0] + ". " + MiddleName[0]+".";
            }
        }
    }
}
