using System;

namespace _3._New_House
{
    class Program
    {
        static void Main(string[] args)
        {

            string flower = Console.ReadLine();
            int flowerCount = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double price = 0;
            double totalPrice = 0;

            if (flower == "Roses")
            {
                totalPrice = 5 * flowerCount;
                if (flowerCount > 80)
                {
                    totalPrice *= 0.90; 
                }
            }
            else if (flower == "Dahlias")
            {
                totalPrice = 3.80 * flowerCount;
                if (flowerCount > 90)
                {
                    totalPrice *= 0.85;
                }
            }
            else if (flower == "Tulips")
            {
               totalPrice = 2.80 * flowerCount;
                if (flowerCount > 80)
                {
                    totalPrice *= 0.85;
                }
            }
            else if (flower == "Narcissus")
            {
                totalPrice = 3 * flowerCount;
                if (flowerCount < 120)
                {
                    totalPrice *= 1.15;
                }
            }
            else if (flower == "Gladiolus")
            {
                totalPrice = 2.50 * flowerCount;
                if (flowerCount < 80)
                {
                    totalPrice *= 1.2;
                }
            }

            double difference = Math.Abs(totalPrice - budget);

            if (budget >= totalPrice)
            {
                Console.WriteLine($"Hey, you have a great garden with {flowerCount} {flower} and {difference:f2} leva left.");
            }
            else if (budget < totalPrice)
            {
                Console.WriteLine($"Not enough money, you need {difference:f2} leva more.");
            }
        }
    }
}
