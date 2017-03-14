using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hmPolyVector
{
    class Program
    {
        static void Main(string[] args)
        {

            Vector[] v = new Vector[10];
            for(int i = 0; i < 10; i++)
            {
                v[i] = new Vector();
                v[i].SetX();
                v[i].SetY();
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Length of {0} vector is {1}", i + 1, v[i].PrintCalc());

            }

            Console.WriteLine();

            for (int i = 0; i < 10; i++)
            {
                if (v[i].PrintCalc()>5)
                {
                    Console.Write(v[i].PrintCalc());
                }
            }
        }
    }
}
