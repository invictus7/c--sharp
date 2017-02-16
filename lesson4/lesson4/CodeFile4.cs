using System;

namespace Lessons
{
    class MainClass3
    {
        public static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            
            if (a > 1000) { a = a * 85 / 100; }
            {
                Console.WriteLine(a);
            }

            if (a < 1000) { a = 1000 - a; }

            {
                Console.WriteLine(a);
            }
        }
    }
}
