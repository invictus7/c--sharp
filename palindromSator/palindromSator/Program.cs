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
            Console.WriteLine("enter 1 symbol pro string");
          string[] palindrom = new string[5];
            palindrom[0] = Console.ReadLine();
            palindrom[1] = Console.ReadLine();
            palindrom[2] = Console.ReadLine();
            palindrom[3] = Console.ReadLine();
            palindrom[4] = Console.ReadLine();
            for (int i = 0; i < 5; i++) ;
            Console.WriteLine("__________________");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(palindrom[i]);
            }
            
                if (palindrom[4] == palindrom[0] && palindrom[3] == palindrom[1])
                {
                Console.WriteLine("palindrom");

            }

        }

        }

    }

