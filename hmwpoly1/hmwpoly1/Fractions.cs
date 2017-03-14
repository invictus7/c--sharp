using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hmwpoly1
{
    class Fractions
    {
        private long a;
        private short b;

        public long A
        {
            get
            {
                return a;
            }
            set
            {
                a = value;
            }
        }

        public short B
        {
            get
            {
                return b;
            }
            set
            {
                b = value;
            }
        }
        
        public  Fractions(long a,short b)
        {
            B = b;
            A = a;
        }




    }
}
