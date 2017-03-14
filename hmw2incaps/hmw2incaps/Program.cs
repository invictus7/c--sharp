using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hmw2incaps
{
    class Program
    {
        static void Main(string[] args)
        {
            Runner a = new Runner("Pablo", 13.2);

            Runner b = new Runner("John", 15.3);
            a.PrintInfo();
            Runner[] timetable = new Runner[2];
            double max = double.MinValue;
            foreach(var timee in timetable)
            {
                if (timee.Time > max)
                {
                    max = timee.Time;

                    

                }

                Console.WriteLine("leader is {0}", timee.Time);
            }
            
        }
    }
}
