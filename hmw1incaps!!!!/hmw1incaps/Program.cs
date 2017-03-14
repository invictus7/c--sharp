using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hmw1incaps
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] st = new int[5] { 1, 3, 5, 6, 7 };
            Student a = new Student("wagern", "germany", st);
            a.PrintInfo();
          

        }
    }
}
