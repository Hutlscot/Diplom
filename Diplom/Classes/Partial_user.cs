using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom
{
    partial class User
    {
        public int Type_user
        {
            get
            {
                return TypeUserId - 1;
            }
            set { }
        }
    }
}
