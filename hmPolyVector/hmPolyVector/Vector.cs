using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hmPolyVector
{
    class Vector
    {
      public  int x;
      public  int y;

        public void  SetX()
        {
            x = int.Parse(Console.ReadLine());
        }
        public void SetY()
        {
            y = int.Parse(Console.ReadLine());
        }



        public double PrintCalc()
        {
            return Math.Sqrt(x * x + y + y);
        }


    }
}
