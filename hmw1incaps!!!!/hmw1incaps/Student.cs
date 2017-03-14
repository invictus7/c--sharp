using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hmw1incaps
{
    class Student
    {

        int[] st = new int[5] { 1, 3, 5, 6, 7 };

        private string pib;
        private float average;
        private string home;
        public float sum;

        public string PIB
        {
            get
            {
                return pib;
            }
            set
            {
                pib = value;

            }
        }
        public float Avarage()
        {
            float sum = 0;

            for (int i = 0; i < 5; ++i)
            {
                sum = sum + st[i];
            }
            return sum / 5;
        }

        public string Home
        {
            get
            {
                return home;
            }
            set
            {
                home = value;
            }
        }

        public Student(string pib1, string home1, int[] mark)
        {
            PIB = pib1;
            Home = home1;
            st = mark;
        }

        public void PrintInfo()
        {
            Console.WriteLine("name\t{0},avarage\t{1},home{2}\t", pib, Avarage(), home);
        }

    }
}