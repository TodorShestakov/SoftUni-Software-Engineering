using System;

namespace after15minutes
{
    class after15minutes
    {
        static void Main(string[] args)
        {

// Вариант 1
            //int hours = int.Parse(Console.ReadLine());
            //int minutes = int.Parse(Console.ReadLine());
            //int totalTime = hours * 60 + minutes;
            //int theHours = (15 + totalTime) / 60;
            //int theMinutes = (15 + totalTime) % 60;

            //if (theHours > 23)
            //{
            //    theHours = 0;
            //}
            //if (theMinutes < 10)
            //{
            //    Console.WriteLine($"{theHours}:0{theMinutes}");
            //}
            //else
            //{
            //    Console.WriteLine($"{theHours}:{theMinutes}");

// Вариант 2           
                int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            minutes += 15;
            if (minutes >= 60)
            {
                minutes -= 60;
                hours += 1;
            }

            if (hours >= 24)
            {
                hours = 0;
            }

            Console.WriteLine($"{hours}:{minutes:d2}");


        }
    }
}