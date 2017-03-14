using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hmstack1
{
    class Program
    {
        static void Main(string[] args)
        {



           String(Console.ReadLine());
        }

            static void String(string s)
            {
                Stack<char> one = new Stack<char>();
                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] == '1')
                    {
                        one.Push(s[i]);
                    }
                }
                int Rivnist = one.Count;
                if (Rivnist % 2 == 0)
                {
                    Console.WriteLine("parna kilkist");
                }
                else Console.WriteLine("neparna kilkist");
            }
        }



    }
    

