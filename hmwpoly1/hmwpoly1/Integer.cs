using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hmwpoly1
{
    class Integer : Fractions


    { public Integer(long a, short b) : base(a, b){}
        public  float CaclMultiplizieren(long a,short b)
        {
            return a * b;
        }
        public  float CalcPlus(long a, short b )
        {
            return a + b;
        }




    }
}
