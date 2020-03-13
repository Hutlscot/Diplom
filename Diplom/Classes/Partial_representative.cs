using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom
{
    partial class Representative
    {
        public int TypeId
        {
            get
            {
                return Type - 1;
            }
            set { }
        }
    }
}
