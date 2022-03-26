using System;

namespace after15minutes
{
    class after15minutes
    {
        static void Main(string[] args)
        {
            string serial = Console.ReadLine();
            int serialTime = int.Parse(Console.ReadLine());
            double breakTime = int.Parse(Console.ReadLine());

            double lunchTime = breakTime / 8;
            double relaxTime = breakTime / 4;

            double timeLeft = breakTime - (lunchTime + relaxTime);

            double difference = Math.Abs(serialTime - timeLeft);

            if (timeLeft >= serialTime)
            {
                Console.WriteLine($"You have enough time to watch {serial} and left with {Math.Ceiling(difference)} minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {serial}, you need {Math.Ceiling(difference)} more minutes.");
            }
        }
    }
}