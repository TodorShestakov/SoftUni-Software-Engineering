using System;

namespace _3._Flowers
{
    class Program
    {
        static void Main(string[] args)
        {

            //Сезон            Хризантеми        Рози             Лалета
            //Пролет / Лято   2.00 лв./ бр.    4.10 лв./ бр.    2.50 лв./ бр.
            //  Есен / Зима   3.75 лв./ бр.    4.50 лв./ бр.    4.15 лв./ бр.

            int hrizantemsNumber = int.Parse(Console.ReadLine());
            int rosesNumber = int.Parse(Console.ReadLine());
            int lalesNumber = int.Parse(Console.ReadLine());
            string season = Console.ReadLine(); //[Spring, Summer, Аutumn, Winter]
            string holiday = Console.ReadLine(); //[Y – да / N - не]

            double hrizantemsPrice = 0;
            double rosesPrice = 0;
            double lalesPrice = 0;

            if (season == "Spring" || season == "Summer")
            {
                hrizantemsPrice = 2.00 * hrizantemsNumber;
                rosesPrice = 4.10 * rosesNumber;
                lalesPrice = 2.50 * lalesNumber;
            }
            if (season == "Autumn" || season == "Winter")
            {
                hrizantemsPrice = 3.75 * hrizantemsNumber;
                rosesPrice = 4.50 * rosesNumber;
                lalesPrice = 4.15 * lalesNumber;
            }

            double totalSum = hrizantemsPrice + rosesPrice + lalesPrice;


            if (season == "Spring" && lalesNumber > 7)
            {
                totalSum *= 0.95;
            }
            if (season == "Winter" && rosesNumber >= 10)
            {
                totalSum *= 0.90;
            }
            if (holiday == "Y")
            {
                totalSum *= 1.15;
            }
            if (hrizantemsNumber + rosesNumber + lalesNumber > 20)
            {
                totalSum *= 0.80;
            }
            Console.WriteLine($"{totalSum + 2:f2}");
        }
    }
}
