using System;

namespace _5._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string location = "";
            string type = "";
            double price = 0;

            if (budget <= 1000)
            {
                type = "Camp";
                if (season == "Summer")
                {
                    location = "Alaska";
                    price = 0.65 * budget;
                }
                else if (season == "Winter")
                {
                    location = "Morocco";
                    price = 0.45 * budget;
                }
            }
            else if (budget > 3000)
            {
                type = "Hotel";
                price = 0.90 * budget;
                if (season == "Summer")
                {
                    location = "Alaska";
                }
                else if (season == "Winter")
                {
                    location = "Morocco";
                }
            }
            else
            {
                type = "Hut";
                if (season == "Summer")
                {
                    location = "Alaska";
                    price = 0.80 * budget;
                }
                else if (season == "Winter")
                {
                    location = "Morocco";
                    price = 0.60 * budget;
                }
            }

            Console.WriteLine($"{location} - {type} - {price:f2}");
        }
    }
}
