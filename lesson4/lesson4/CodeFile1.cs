using System;

namespace Lessons
{
    class MainClass
    {
        public static void Main()
        {

            Console.WriteLine("enter drink");
            string drink = Console.ReadLine().ToLower().Trim();
            // coffe = coffe();
            // coffe = coffe();
            switch (drink)
            {

                case "late":
                case "latte":
                    Console.WriteLine("20$");
                    break;
                case "americano":
                    Console.WriteLine("10$");
                    break;
                case "expresso":
                case "espresso":
                    Console.WriteLine("5$");
                    break;
                default:
                    string NewDrink = drink.Contains("tea") ? "tea" : drink;

                    if (NewDrink == "tea")
                        Console.WriteLine("here is tea");
                    else
                        Console.WriteLine("Try again");
                    break;

            }
        }
    }
}


    

