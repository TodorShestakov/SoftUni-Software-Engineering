using System;

namespace _1._Sum_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {

//Вариант 1
            //int firstTime = int.Parse(Console.ReadLine());
            //int secondTime = int.Parse(Console.ReadLine());
            //int thirdTime = int.Parse(Console.ReadLine());

            //int totalTime = firstTime + secondTime + thirdTime;

            //int minutes = totalTime / 60;
            //int seconds = totalTime % 60;

            //if (seconds < 10)
            //{
            //    Console.WriteLine($"{minutes}:0{seconds}");
            //}

            //else
            //{
            //    Console.WriteLine($"{minutes}:{seconds}");
            //}


// Вариант 2
            //int firstTime = int.Parse(Console.ReadLine());
            //int secondTime = int.Parse(Console.ReadLine());
            //int thirdTime = int.Parse(Console.ReadLine());

            //int totalTime = firstTime + secondTime + thirdTime;

            //int minutes = totalTime / 60;
            //int seconds = totalTime % 60;

           
            // Console.WriteLine($"{minutes}:{seconds:d2}");

// Вариант 3
            int totalSeconds = 0;
            totalSeconds += int.Parse(Console.ReadLine());
            totalSeconds += int.Parse(Console.ReadLine());
            totalSeconds += int.Parse(Console.ReadLine());


            int minutes = totalSeconds / 60;
            int seconds = totalSeconds % 60;


            Console.WriteLine($"{minutes}:{seconds:d2}");





        }
    }
}
