using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2
{
    abstract class Arty
    {

        public string line = "bob friedn my Hello";
        public string Line2
        {
            get { return line; }
            set { line = value; }

        }

        public void Rotate()
        {
            string[] line = Line2.Split(' ');
            for (int i = 0; i < line.Length; i++)
            {
                Console.WriteLine(line);

            }



        }

        public void Method() {
            Stack<string> Line = new Stack<string>;
            int i = 0;
            for (; i < Line.Length - 1; i++)
            {
                Line.Push();
            }
            for (; i < Line.Length - 1; i++)
            {
                Line.Pop();
            }
            for (; i < Line.Length - 1; i++)
            {
                Line.Count();
            }
            return ToString();

        }
      
        
        
        //залишилось реалізувати метод...


}
}






