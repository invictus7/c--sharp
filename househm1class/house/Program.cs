using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson12
{
    class Program
    {
        static void Main(string[] args)
        {
            House h1 = new House();
            float price = h1.Calc();
            h1.Area = 1500;
            h1.PrintInfo();//викликає метод

        }
    }
}
