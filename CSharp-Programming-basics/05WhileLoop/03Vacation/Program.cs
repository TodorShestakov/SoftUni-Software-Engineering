﻿using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            double neededVacationMoney = double.Parse(Console.ReadLine());
            double currMoney = double.Parse(Console.ReadLine());

            int days = 0;
            int spentCounter = 0;


            while (spentCounter != 5)
            {
                string input = Console.ReadLine();
                double money = double.Parse(Console.ReadLine());
                days++;

                if (input == "save")
                {
                    currMoney += money;
                    spentCounter = 0;
                }
                else if (input == "spend")
                {
                    spentCounter++;
                    if (money > currMoney)
                    {
                        currMoney = 0;
                    }
                    else
                    {
                        currMoney -= money;
                    }
                }
                if (currMoney >= neededVacationMoney)
                {
                    Console.WriteLine($"You saved the money for {days} days.");
                    break;
                }

            }

            if (spentCounter == 5)
            {
                Console.WriteLine($"You can't save the money.");
                Console.WriteLine(days);
            }


        }
    }
}
