using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hwmetods2
{
    class Program
    {
        public static void Metod(string h,int a,int b,int c)
        {
            int sum = a + b + c;
            if (sum== 20)
            {
                Console.WriteLine(h);
            }else
            {
                Console.WriteLine("sorry but sum==" + sum);
            }
        }




        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            Metod("heil", a,b,c);

        }
    }
}
