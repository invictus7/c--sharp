using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindrom
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] palindrom = new string[5];
            palindrom[0] = Console.ReadLine();
            palindrom[1] = Console.ReadLine();
            palindrom[2] = Console.ReadLine() ;
            palindrom[3] = Console.ReadLine() ;
            palindrom[4] = Console.ReadLine();
            for (int i = 0; i < 5; i++) ;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("__________________");
                Console.WriteLine(palindrom[i]);
            }
            for (int i = 0; i < 5; i++)
            {
                if (palindrom[4] == palindrom[0] && palindrom[3] == palindrom[1])
            {
            }

            }
            Console.WriteLine("palindrom");

        }

    }

}