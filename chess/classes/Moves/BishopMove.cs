﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chess
{
    class BishopMove : MoveBehavior
    {
        public bool makemove(int oldrow, int oldcolmn, int newrow, int newcolmn)
        {
            int ver_diff = Math.Abs(oldrow - newrow);
            int hor_diff = Math.Abs(oldcolmn - newcolmn);

            if (hor_diff == ver_diff&&hor_diff != 0)
               
                    return true;

            return false;
            
        }
    }
}
