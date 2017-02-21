using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            int[,] matrix = new int[n,n ];


           // for (int i = 0; i < 4; i++) ;
            //for (int j = 0; j < 4; j++) ;

            for (int i = 0; i < n-1; i++)
            {
                for (int j = 0; j < n-1; j++)
                {
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }


            }

            Console.WriteLine("_______________");


            for (int i = 0; i < n-1; i++)
            {
                for (int j = 0; j < n-1; j++)
                {
                    Console.Write("{0}\t", matrix[i, j]);
                }
                Console.WriteLine();
            }

           

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                   // int sum = 0;
                   // Console.WriteLine( sum=i+j);
                }
            }



                    //int MainDiagonal = (matrix[0, 0] + matrix[1, 1] + matrix[2, 2] + matrix[3, 3]);
                    //Console.WriteLine("________");
                    //Console.WriteLine(MainDiagonal);
                    //Console.WriteLine();



                }

    }
}
