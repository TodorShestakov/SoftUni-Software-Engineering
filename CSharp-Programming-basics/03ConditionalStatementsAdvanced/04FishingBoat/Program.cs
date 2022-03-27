using System;

namespace _4._Fishing_Boat
{
    class Program
    {
        static void Main(string[] args)
        {

            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermanCount = int.Parse(Console.ReadLine());

            double rent = 0;
            double totalPrice = 0;
            //"Spring", "Summer", "Autumn", "Winter"
            if (season == "Spring")
            {
                rent = 3000;
                if (fishermanCount <= 6)
                {
                    rent *= 0.9;
                }
                else if (fishermanCount >= 7 && fishermanCount <= 11)
                {
                    rent *= 0.85;
                }
                else if (fishermanCount >= 12)
                {
                    rent *= 0.75;
                }
            }
            else if (season == "Summer" || season == "Autumn")
            {
                rent = 4200;
                if (fishermanCount <= 6)
                {
                    rent *= 0.9;
                }
                else if (fishermanCount >= 7 && fishermanCount <= 11)
                {
                    rent *= 0.85;
                }
                else if (fishermanCount >= 12)
                {
                    rent *= 0.75;
                }
            }
            else if (season == "Winter")
            {
                rent = 2600;
                if (fishermanCount <= 6)
                {
                    rent *= 0.9;
                }
                else if (fishermanCount >= 7 && fishermanCount <= 11)
                {
                    rent *= 0.85;
                }
                else if (fishermanCount >= 12)
                {
                    rent *= 0.75;
                }
            }
            if ((fishermanCount % 2 == 0) && (season == "Spring" || season == "Summer" || season == "Winter"))
            {
                rent *= 0.95;
            }

            double difference = Math.Abs(budget - rent);

            if (budget >= rent)
            {
                Console.WriteLine($"Yes! You have {difference:f2} leva left.");
            }
            else if (budget < rent)
            {
                Console.WriteLine($"Not enough money! You need {difference:f2} leva.");
            }
        }
    }
}
