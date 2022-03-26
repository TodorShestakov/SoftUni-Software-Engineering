using System;

namespace after15minutes
{
    class after15minutes
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int vCardsCOUNT = int.Parse(Console.ReadLine());
            int processorsCOUNT = int.Parse(Console.ReadLine());
            int ramCOUNT = int.Parse(Console.ReadLine());

            double vCardsPRICE = vCardsCOUNT * 250;
            double processorsPRICE = 0.35 * vCardsPRICE;
            double ramsPRICE = 0.10 * vCardsPRICE;

            double totalPRICE = vCardsPRICE + processorsPRICE * processorsCOUNT + ramsPRICE * ramCOUNT;

            if (vCardsCOUNT > processorsCOUNT)
            {
                totalPRICE = 0.85 * totalPRICE;
            }

            double difference = Math.Abs(totalPRICE - budget);

            if (totalPRICE <= budget)
            {
                Console.WriteLine($"You have {difference:f2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {difference:f2} leva more!");
            }
        }
    }
}