using System;

namespace _3._Sum_Prime_Non_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            int sumOfPrimeNum = 0;
            int sumOfNonPrimeNum = 0;


            while (command != "stop")
            {

                int number = int.Parse(command);
                if (number < 0)
                {
                    Console.WriteLine("Number is negative.");
                }
                else
                {
                    int count = 0;
                    for (int i = 1; i <= number; i++)
                    {
                        // number = 4
                        // number % 1 == 0 -> true count 1
                        // number % 2 == 0 -> true count 2
                        // number % 3 == 0 -> false count 2 ( не се увеличаава )
                        // number % 4 == 0 -> true count 3
                        // sumOfNonPrimeNum += number;

                        if (number % i == 0)
                        {
                            count++;
                        }
                    }
                    if (count == 2)
                    {
                        sumOfPrimeNum += number;
                    }
                    else
                    {
                        sumOfNonPrimeNum += number;
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Sum of all prime numbers is: {sumOfPrimeNum}");
            Console.WriteLine($"Sum of all non prime numbers is: {sumOfNonPrimeNum}");

        }
    }
}
