using System;

namespace _2._Bike_Race
{
    class Program
    {
        static void Main(string[] args)
        {


            int juniorBikers = int.Parse(Console.ReadLine());
            int elderBikers = int.Parse(Console.ReadLine());
            string trace = Console.ReadLine(); //"trail", "cross-country", "downhill" или "road"

            double priceJ = 0;
            double priceE = 0;
            double totalPrice = 0;

            if (trace == "trail")
            {
                priceJ = juniorBikers * 5.50;
                priceE = elderBikers * 7;
                
            }
            else if (trace == "cross-country")
            {
                priceJ = juniorBikers * 8;
                priceE = elderBikers * 9.50;
                if ((juniorBikers + elderBikers) >= 50)
                {
                    priceJ *= 0.75;
                    priceE *= 0.75;
                }
            }
            else if (trace == "downhill")
            {
                priceJ = juniorBikers * 12.25;
                priceE = elderBikers * 13.75;
            }
            else if (trace == "road")
            {
                priceJ = juniorBikers * 20;
                priceE = elderBikers * 21.50;
            }

            totalPrice = 0.95 * (priceJ + priceE);

            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}
