using System;

namespace _4._Clever_Lily
{
    class Program
    {
        static void Main(string[] args)
        {

            //•	Възрастта на Лили - цяло число в интервала[1...77]
            //•	Цената на пералнята - число в интервала[1.00...10 000.00]
            //•	Единична цена на играчка -цяло число в интервала[0...40]


            int age = int.Parse(Console.ReadLine());
            double peralnqPrice = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());

            int moneyYears = 0;
            int money = 0;
            int savedMoney = 0;
            int toyYears = 0;

            for (int i = 1; i <= age; i++)
            {

                if (i % 2 == 0)
                {
                    moneyYears += 1;
                    money = moneyYears * 10;
                    savedMoney += money; 
                }
                else
                {
                    toyYears++;
                }
                
            }


            money = savedMoney - moneyYears + (toyYears * toyPrice);

            double difference = Math.Abs(money - peralnqPrice);

            if (money >= peralnqPrice)
            {
                Console.WriteLine($"Yes! {difference:f2}");
            }
            else
            {
                Console.WriteLine($"No! {difference:f2}");
            }


        }
    }
}
