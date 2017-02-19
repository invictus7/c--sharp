using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrix2
{
    class Program
    {
        static void Main(string[] args)
        {
            double s = 12.5;
            double similar = 0;
            int[,] matrix1 = new int[4, 4];
            Random ran = new Random();

            for (int i = 0; i < 4; i++) ;
            for (int j = 0; j < 4; j++) ;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {

                    matrix1[i, j] = ran.Next(1, 20);
                    Console.Write("{0}\t", matrix1[i, j]);

                }


                Console.WriteLine();
            }
            Console.WriteLine("matrix2");

            int[,] matrix2 = new int[4, 4];
            Random ran2 = new Random();

            for (int i = 0; i < 4; i++) ;
            for (int j = 0; j < 4; j++) ;

            for (int a = 0; a < 4; a++)
            {
                for (int b = 0; b < 4; b++)
                {
                    matrix2[a, b] = ran.Next(1, 20);
                    Console.Write("{0}\t", matrix2[a, b]);
                }
                Console.WriteLine();

            }
            if (matrix1 == matrix2)
            {
                Console.WriteLine(100);
            }
            else
            {
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if (matrix1[i,j]== matrix2[i,j])
                        {
                            similar = s + similar;
                        }


                    }

                }
                Console.WriteLine(+similar);
            }
        }

    }
}
