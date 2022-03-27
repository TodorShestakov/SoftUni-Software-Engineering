using System;

namespace after15minutes
{
    class after15minutes
    {
        static void Main(string[] args)
        {

            int LozeM2 = int.Parse(Console.ReadLine());
            double grapesPerM2 = double.Parse(Console.ReadLine());
            int neededLitersWine = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());

            double proizvodstvo = LozeM2 * grapesPerM2;
            double grapesForWine = 0.4 * proizvodstvo;
            double wineLiters = grapesForWine / 2.5;

            double difference = Math.Abs(neededLitersWine - wineLiters);

            if (wineLiters < neededLitersWine)
            {
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(difference)} liters wine needed.");
            }

            else
            {
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(wineLiters)} liters.");
                Console.WriteLine($"{Math.Ceiling(difference)} liters left -> {Math.Ceiling((wineLiters - neededLitersWine) / workers)} liters per person.");
            }



        }
    }
}