using System;

namespace _5._Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string type = "";
            string destination = "";
            double price = 0;
            if (season == "summer")
            {
                type = "Camp";
                if (budget <= 100)
                {
                    destination = "Bulgaria";
                    price = 0.3 * budget;
                }
                else if (budget > 1000)
                {
                    destination = "Europe";
                    price = 0.9 * budget;
                    type = "Hotel";
                }
                else 
                {
                    destination = "Balkans";
                    price = 0.4 * budget;
                }
            }
            else if (season == "winter")
            {
                type = "Hotel";
                if (budget <= 100)
                {
                    destination = "Bulgaria";
                    price = 0.7 * budget;
                }
                else if (budget > 1000)
                {
                    destination = "Europe";
                    price = 0.9 * budget;
                    type = "Hotel";
                }
                else
                {
                    destination = "Balkans";
                    price = 0.8 * budget;
                }
            }                           
                Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{type} - {price:f2}");
        }
    }
}
