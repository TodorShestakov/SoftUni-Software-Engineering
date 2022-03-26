using System;

namespace after15minutes
{
    class after15minutes
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double timeToSwimOneMeter = double.Parse(Console.ReadLine());
            double swimmingTime = distance * timeToSwimOneMeter;

            double delays = Math.Floor(distance / 15);
            double delayTime = delays * 12.5;
            double totalTime = swimmingTime + delayTime;

            if (totalTime < record)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {totalTime:f2} seconds.");
            }

            else
            {
                Console.WriteLine($"No, he failed! He was {(totalTime - record):f2} seconds slower.");
            }
        }
    }
}