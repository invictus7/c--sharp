using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson12
{
    class House
    {
        public int numOfRooms;
        public int numOfBathrooms;
        public float area=150F;
        public float price=400F;
        public static float  permeter;
       // public int calc;


        public int NunOfRooms
        {
            get
            {
                return numOfRooms;
            }
            set
            {
                numOfRooms = value;
                Calc();
            }
        }



        public int  NumOfBathrooms
        {
            get
            {
                return numOfBathrooms;
            }
            set
            {
                numOfBathrooms = value;
                Calc();
            }
        }


        public float Area
        {
            get
            {
                return area;
            }
            set
            {
                area = value;
                Calc();
            }

        }


        public float Price
        {
            get
            {
                return price;
            }
            set
            {
                price  = value;
                Calc();//оновлює прайс
            }
        }
        

        
        public float  Calc()//метод для підрахунку
        {
            permeter = price / area;
            return permeter;
        }
        public void PrintInfo()//метогд для виводу,метод потрібно викликати
        {
            Console.WriteLine(permeter);
        }
        
    }
}
