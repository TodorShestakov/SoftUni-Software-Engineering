using System;

namespace _2._Sleepy_Tom_Cat
{
    class Program
    {
        static void Main(string[] args)
        {
            int pochivniDni = int.Parse(Console.ReadLine());

            int daysInYear = 365;
            int rabotniDni = daysInYear - pochivniDni;
            int needPlayTime = 30000;

            int igrasTomvPochivniDni = pochivniDni * 127;
            int igrasTomvRabotniDni = rabotniDni * 63;
            int RealGameTime = igrasTomvPochivniDni + igrasTomvRabotniDni;

            int igraH = Math.Abs(needPlayTime - RealGameTime) / 60;
            int igraM = Math.Abs(needPlayTime - RealGameTime) % 60;

            if (RealGameTime >= needPlayTime)
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{igraH} hours and {igraM} minutes more for play");
            }
            else
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{igraH} hours and {igraM} minutes less for play");
            }

// VARIANT 2
            //int breakDays = int.Parse(Console.ReadLine());
            //int norma = 30000;
            //int workDays = 365 - breakDays;
            //int timeIgra = workDays * 63 + breakDays * 127;
            //int mins = Math.Abs(norma - timeIgra) % 60;
            //int hours = Math.Abs(norma - timeIgra) / 60;
            //if (timeIgra >= norma)
            //{
            //    Console.WriteLine("Tom will run away");
            //    Console.WriteLine($"{hours} hours and {mins} minutes more for play");
            //}
            //else
            //{
            //    Console.WriteLine("Tom sleeps well");
            //    Console.WriteLine($"{hours} hours and {mins} minutes less for play");
            //}





        }
    }
}
