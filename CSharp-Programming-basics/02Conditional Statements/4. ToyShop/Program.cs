using System;

namespace after15minutes
{
    class after15minutes
    {
        static void Main(string[] args)
        {
            const double puzzlePrice = 2.60;
            const double dollPrice = 3;
            const double bearPrice = 4.10;
            const double minionPrice = 8.20;
            const double truckPrice = 2;

            double excursionPrice = double.Parse(Console.ReadLine());
            int puzzleCount = int.Parse(Console.ReadLine());
            int dollCount = int.Parse(Console.ReadLine());
            int bearCount = int.Parse(Console.ReadLine());
            int minionCount = int.Parse(Console.ReadLine());
            int truckCount = int.Parse(Console.ReadLine());

            int totalToys = puzzleCount + dollCount + bearCount + minionCount + truckCount;
            double totalPrice = puzzlePrice * puzzleCount + dollPrice * dollCount + bearPrice * bearCount + minionPrice * minionCount + truckPrice * truckCount;

            if (totalToys >= 50)
            {
                totalPrice = 0.75 * totalPrice;
            }

            double rent = totalPrice * 0.10;
            double difference = Math.Abs(excursionPrice + rent - totalPrice);

            if (totalPrice >= rent + excursionPrice)
            {
                Console.WriteLine($"Yes! {difference:f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {difference:f2} lv needed.");
            }
        }
    }
}