using System;

namespace _5.GodzillaVSKong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int personsCount = int.Parse(Console.ReadLine());
            double clothesPricePerPerson = double.Parse(Console.ReadLine());

            double totalClothesPrice = personsCount * clothesPricePerPerson;

            double decorPrice = budget * 0.10;

            if (personsCount > 150)
            {
                totalClothesPrice = 0.9 * totalClothesPrice;
            }

            double difference = Math.Abs(totalClothesPrice + decorPrice - budget);

            if (budget >= totalClothesPrice + decorPrice)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {difference:f2} leva left.");
            }
            else
            {

                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {difference:f2} leva more.");
            }           
        }
    }
}
