using System;

namespace _7._Flower_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int magnolies = int.Parse(Console.ReadLine());
            int zombules = int.Parse(Console.ReadLine());
            int roses = int.Parse(Console.ReadLine());
            int cactuses = int.Parse(Console.ReadLine());
            double giftPrice = double.Parse(Console.ReadLine());

            double magnoliesPrice = magnolies * 3.25;
            double zombulesPrice = zombules * 4;
            double rosesPrice = roses * 3.50;
            double cactusesPrice = cactuses * 8;

            double totalPrice = 0.95 * (magnoliesPrice + zombulesPrice + rosesPrice + cactusesPrice);

            double difference = Math.Abs(totalPrice - giftPrice);

            if (totalPrice >= giftPrice)
            {
                Console.WriteLine($"She is left with {Math.Floor(difference)} leva.");
            }
            else
            {
                Console.WriteLine($"She will have to borrow {Math.Ceiling(difference)} leva.");
            }



        }
    }
}
