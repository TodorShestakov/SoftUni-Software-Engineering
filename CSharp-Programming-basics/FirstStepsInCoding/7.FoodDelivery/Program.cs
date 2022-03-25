using System;

namespace _7.FoodDelivery
{
    class Program
    {
        static void Main(string[] args)
        {


            double chickenMenu = double.Parse(Console.ReadLine());
            double fishMenu = double.Parse(Console.ReadLine());
            double vegeMenu = double.Parse(Console.ReadLine());

            double deliveryPrice = 2.5;


            double menusPrice = chickenMenu * 10.35 + fishMenu * 12.4 + vegeMenu * 8.15;
            double dessertPrice = menusPrice * 0.2;

            double orderPrice = menusPrice + dessertPrice + deliveryPrice;

            Console.WriteLine(orderPrice);

        }
    }
}
