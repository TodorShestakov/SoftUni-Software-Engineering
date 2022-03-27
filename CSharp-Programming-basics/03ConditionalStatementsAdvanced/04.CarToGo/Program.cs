using System;

namespace _4._Car_To_Go
{
    class Program
    {
        static void Main(string[] args)
        {

            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string type = "";
            string clas = "";
            double price = 0;

            if (budget <= 100)
            {
                clas = "Economy class";
                if (season == "Summer")
                {
                    type = "Cabrio";
                    price = 0.35 * budget;
                }
                else if (season == "Winter")
                {
                    type = "Jeep";
                    price = 0.65 * budget;
                }
            }
            else if (budget > 500)
            {
                clas = "Luxury class";
                type = "Jeep";
                price = 0.90 * budget;
            }
            else
            {
                clas = "Compact class";
                if (season == "Summer")
                {
                    type = "Cabrio";
                    price = 0.45 * budget;
                }
                else if (season == "Winter")
                {
                    type = "Jeep";
                    price = 0.80 * budget;
                }
            }

            Console.WriteLine($"{clas}");
            Console.WriteLine($"{type} - {price:f2}");
        }
    }
}
