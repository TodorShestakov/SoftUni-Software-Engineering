using System;

namespace _8.FuelTankPart_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	Типа на горивото – текст с възможности: "Gas", "Gasoline" или "Diesel"
            //•	Количество гориво – реално число в интервала[1.00 … 50.00]
            //•	Притежание на клубна карта – текст с възможности: "Yes" или "No"

            string fuelType = Console.ReadLine();
            double litersFuel = double.Parse(Console.ReadLine());
            string clubCard = Console.ReadLine();

            double benzinPrice = 2.22;
            double dieselPrice = 2.33;
            double gasPrice = 0.93;

            double totalbenzinPrice = 0;
            double totaldieselPrice = 0;
            double totalgasPrice = 0;

            if (clubCard == "Yes")
            {
                totalbenzinPrice = litersFuel * (benzinPrice - 0.18);
                totaldieselPrice = litersFuel * (dieselPrice - 0.12);
                totalgasPrice = litersFuel * (gasPrice - 0.08);
            }
            else
            {
                totalbenzinPrice = litersFuel * benzinPrice;
                totaldieselPrice = dieselPrice * litersFuel;
                totalgasPrice = gasPrice * litersFuel;
            }

            if (fuelType == "Gasoline")
            {
                if (litersFuel >= 20 && litersFuel <= 25)
                {
                    totalbenzinPrice *= 0.92;
                    Console.WriteLine($"{totalbenzinPrice:f2} lv.");
                }
                else if (litersFuel > 25)
                {
                    totalbenzinPrice *= 0.90;
                    Console.WriteLine($"{totalbenzinPrice:f2} lv.");
                }
                else
                {
                    Console.WriteLine($"{totalbenzinPrice:f2} lv.");
                }
            }
            else if (fuelType == "Diesel")
            {
                if (litersFuel >= 20 && litersFuel <= 25)
                {
                    totaldieselPrice *= 0.92;
                    Console.WriteLine($"{totaldieselPrice:f2} lv.");
                }
                else if (litersFuel > 25)
                {
                    totaldieselPrice *= 0.90;
                    Console.WriteLine($"{totaldieselPrice:f2} lv.");
                }
                else
                {
                    Console.WriteLine($"{totaldieselPrice:f2} lv.");
                }
            }
            else if (fuelType == "Gas")
            {
                if (litersFuel >= 20 && litersFuel <= 25)
                {
                    totalgasPrice *= 0.92;
                    Console.WriteLine($"{totalgasPrice:f2} lv.");
                }
                else if (litersFuel > 25)
                {
                    totalgasPrice *= 0.90;
                    Console.WriteLine($"{totalgasPrice:f2} lv.");
                }
                else
                {
                    Console.WriteLine($"{totalgasPrice:f2} lv.");
                }
            }

            //Ако шофьора е заредил между 20 и 25 литра включително, той получава 8 процента отстъпка от крайната цена, 
            //                при повече от 25 литра гориво, той получава 10 процента отстъпка от крайната цена.







        }
    }
}
