using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hmwstack2
{
    class Program
    {
        static void Main(string[] args)
        {

            
            
              String(Console.ReadLine());
        }

            static void String(string s)
            {
                Stack<char> sum = new Stack<char>();
                int i = 0;

                while (s[i] != '0')
                {
                    sum.Push(s[i]);
                    i++;

                }

                for (; i < s.Length-1 ; i++)
                {
                    if (sum.Peek() == s[i+1 ])
                    {
                        sum.Pop();
                    }
                    else
                    {
                        Console.WriteLine("wrong");
                    }
                }


            }
    }
}
