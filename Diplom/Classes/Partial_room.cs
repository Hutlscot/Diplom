using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom
{
    partial class Room
    {
        public int Free_place
        {
            get
            {
                int x = NumberOfPlace - Contracts.Count;
                if(x>0)
                {
                    return x;
                }
                return 0;
            }
        }
    }
}
