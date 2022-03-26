using System;

namespace after15minutes
{
    class after15minutes
    {
        static void Main(string[] args)
        {



            //            •	Първият ред съдържа числото n – брой километри – цяло число в интервала[1…5000]
            //•	Вторият ред съдържа дума “day” или “night” – пътуване през деня или през нощта

            int distance = int.Parse(Console.ReadLine());
            string dayOrNight = Console.ReadLine();

            double price = 0;
            double taxiRate = 0;

            if (dayOrNight == "day")
            {
                taxiRate = 0.79;
            }
            else
            {
                taxiRate = 0.90;
            }

            if (distance < 20)
            {
                price = 0.70 + distance * taxiRate;
            }
            else if (distance >= 100)
            {
                price = 0.06 * distance;
            }
            else
            {
                price = 0.09 * distance;
            }

            Console.WriteLine($"{price:f2}");
        }
    }
}