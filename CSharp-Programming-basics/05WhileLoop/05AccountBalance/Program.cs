using System;

namespace _5._While_loop
{
    class Program
    {
        static void Main(string[] args)
        {


            string input = Console.ReadLine();  // "400"

            double totalAmount = 0;

            while (input != "NoMoreMoney")
            {

                double currentAmount = double.Parse(input); // "400" -> 400

                if (currentAmount < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }

                totalAmount += currentAmount;

                Console.WriteLine($"Increase: {currentAmount:f2}");
                input = Console.ReadLine();
            }

            Console.WriteLine($"Total: {totalAmount:f2}");

        }
    }
}
