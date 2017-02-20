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
            int[,] matrix = new int[4, 4];
            matrix[3, 3] = int.Parse(Console.ReadLine());
            matrix[3, 2] = int.Parse(Console.ReadLine());
            matrix[3, 1] = int.Parse(Console.ReadLine());
            matrix[3, 0] = int.Parse(Console.ReadLine());

            matrix[2, 3] = int.Parse(Console.ReadLine());
            matrix[2, 2] = int.Parse(Console.ReadLine());
            matrix[2, 1] = int.Parse(Console.ReadLine());
            matrix[2, 0] = int.Parse(Console.ReadLine());

            matrix[1, 3] = int.Parse(Console.ReadLine());
            matrix[1, 2] = int.Parse(Console.ReadLine());
            matrix[1, 1] = int.Parse(Console.ReadLine());
            matrix[1, 0] = int.Parse(Console.ReadLine());

            matrix[0, 3] = int.Parse(Console.ReadLine());
            matrix[0, 2] = int.Parse(Console.ReadLine());
            matrix[0, 1] = int.Parse(Console.ReadLine());
            matrix[0, 0] = int.Parse(Console.ReadLine());

            for (int i = 0; i < 4; i++) ;
            for (int j = 0; j < 4; j++) ;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                }


            }

            Console.WriteLine("_______________");


            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write("{0}\t", matrix[i,j]);
                }
                Console.WriteLine();
            }
            int MainDiagonal = (matrix[0, 0] + matrix[1, 1] + matrix[2, 2] + matrix[3, 3]);
            Console.WriteLine("________");
            Console.WriteLine(MainDiagonal);
            Console.WriteLine();



        }

    }
}
