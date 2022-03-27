using System;

namespace _6._Truck_Driver
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            double kmPerMonth = double.Parse(Console.ReadLine());

            double price = 0;

            if (kmPerMonth <= 5000)
            {
                if ((season == "Spring") || (season == "Autumn"))
                {
                    price = (kmPerMonth * 4) * 0.75;
                }
                else if (season == "Summer")
                {
                    price = (kmPerMonth * 4) * 0.90;
                }
                else if (season == "Winter")
                {
                    price = (kmPerMonth * 4) * 1.05;
                }
            }
            else if ((kmPerMonth > 5000) && (kmPerMonth <= 10000))
            {
                if ((season == "Spring") || (season == "Autumn"))
                {
                    price = (kmPerMonth * 4) * 0.95;
                }
                else if (season == "Summer")
                {
                    price = (kmPerMonth * 4) * 1.10;
                }
                else if (season == "Winter")
                {
                    price = (kmPerMonth * 4) * 1.25;
                }
            }
            else if ((kmPerMonth > 10000) && (kmPerMonth <= 20000))
            {
                price = (kmPerMonth * 4) * 1.45;               
            }

            price *= 0.90;

            Console.WriteLine($"{price:f2}");

        }
    }
}
