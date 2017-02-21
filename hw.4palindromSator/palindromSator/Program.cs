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
            string palindrom = Console.ReadLine();
            //palindrom[0] = Console.ReadLine();
            //palindrom[1] = Console.ReadLine();
            //palindrom[2] = Console.ReadLine();
            //palindrom[3] = Console.ReadLine();
            //palindrom[4] = Console.ReadLine();
            //for (int i = 0; i < 5; i++) ;
            Console.WriteLine("__________________");

            {
            for (int j = 0; j < palindrom.Length ; j++)
                Console.WriteLine(palindrom[j]);
            }


            int n = palindrom.Length;
            int i = 0;

            while (palindrom[i] == palindrom[n - 1 - i] && i < n / 2)
            {
                Console.WriteLine(i+ " - " + (n - 1 - i));
                i = i + 1;
            }
            Console.WriteLine(i);

            //if (i == n / 2)
            //{
            //    Console.WriteLine("palindrom");

            //}
            //else
            //{
            //    Console.WriteLine("eror");

            //}
            //Console.Read();

        }
        //(palindrom[4] == palindrom[0] && palindrom[3] == palindrom[1])
        //   {
        //   Console.WriteLine("palindrom");if



    }

        }

    

