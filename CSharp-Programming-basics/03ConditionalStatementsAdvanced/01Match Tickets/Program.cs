using System;

namespace _1._Match_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {

                double budget = double.Parse(Console.ReadLine());
                string category = Console.ReadLine();  // "VIP" "Normal"
                int people = int.Parse(Console.ReadLine());
            double price = 0;
            double transport = 0;
            if (category == "VIP")
            {
                price = 499.99;
                if (people >= 1 && people <= 4)
                {
                    transport = 0.75 * budget;
                }
                else if (people >= 5 && people <= 9)
                {
                    transport = 0.6 * budget;
                }
                else if (people >= 10 && people <= 24)
                {
                    transport = 0.5 * budget;
                }
                else if (people >= 25 && people <= 49)
                {
                    transport = 0.4 * budget;
                }
                else if (people >= 50)
                {
                    transport = 0.25 * budget;
                }
            }
            
            else if (category == "Normal")
            {
                price = 249.99;
                if (people >= 1 && people <= 4)
                {
                    transport = 0.75 * budget;
                }
                else if (people >= 5 && people <= 9)
                {
                    transport = 0.6 * budget;
                }
                else if (people >= 10 && people <= 24)
                {
                    transport = 0.5 * budget;
                }
                else if (people >= 25 && people <= 49)
                {
                    transport = 0.4 * budget;
                }
                else if (people >= 25 && people <= 49)
                {
                    transport = 0.2 * budget;
                }
            }

            double totalPrice = (price * people) + transport;

            double difference = Math.Abs(totalPrice - budget);

            if (budget >= totalPrice)
            {
                Console.WriteLine($"Yes! You have {difference:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {difference:f2} leva.");
            }
        }
    }
}
