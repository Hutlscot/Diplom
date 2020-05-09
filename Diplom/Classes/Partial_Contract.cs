using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom
{
    partial class Contract
    {
        //студента совершеннолетний?
        public bool Adult
        {
            get
            {
                if ((DateStart.Year - Student.DateOfBirth.Year) < 18)
                {
                    return false;
                }
                return true;
            }
        }
    }
}
