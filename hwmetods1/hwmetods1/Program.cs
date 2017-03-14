using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hwmetods1
{
    class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("________");
            int c = 15;
            int[] mass = new int[c];
            Random ran = new Random();

            for (int i = 0; i < c; i++)
            {
                mass[i] = ran.Next(1, 15);

                Console.WriteLine(mass[i]);
            }
            Console.WriteLine("________________");

            int res = Method1(n,mass);
            Console.WriteLine(res);

        }

     
        public static int Method1(int n,  int[] mass)
        {

            for (int i = 0; i < 15;i++)
            {
               

                if (mass[i] == n)
                {
                    return i;
                }
                //else
                //{
                //    return mass[n];
                //        }

               
            }
            return -1 ;


            }



        }
    }



