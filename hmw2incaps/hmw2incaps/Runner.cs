using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hmw2incaps
{
    class Runner
    {
       public string pib;
       public double time;

       public string PIB
        {
            get
            {
                return pib;
            }
            set
            {
                pib = value;
                PrintInfo();
            }
        }
       public double Time
        {
            get
            {
                return time;
            }
            set
            {
                time = value;
                PrintInfo();
            }
        }
        public Runner(string pib,double time)
        {
           PIB=pib;
            Time = time;
        }
        public void PrintInfo()
        {
            Console.WriteLine("pib{0},time{1}", pib, time);
        }

    }

}
