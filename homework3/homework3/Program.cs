using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Is it day? [y/n]");
            string isDay1 = Console.ReadLine();
            bool isDay = (isDay1 == "y");

            Console.WriteLine("Enter km");

            int km =int.Parse(Console.ReadLine());
            int priceForKm = 0;

            if (km <= 10)
            {
                priceForKm = 5;
            }
            else if (km <= 20)
            {
                priceForKm = 4;
            }
            else if (km>20)
            {
                priceForKm = 3;
            }

            double price = 30 + km * priceForKm;
            if (!isDay)
            {
                price = price / 2;
            }
            Console.WriteLine("Thats your price");
            Console.WriteLine(price);

        }
    }
}

        


    

