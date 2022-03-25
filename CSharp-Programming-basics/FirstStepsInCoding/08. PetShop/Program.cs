using System;

namespace _08._PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int dogFoodCount = int.Parse(Console.ReadLine());
            int catFoodCount = int.Parse(Console.ReadLine());

            double dogFoodPrice = 2.5 * dogFoodCount;
            double catFoodPrice = 4 * catFoodCount;

            Console.WriteLine($"{dogFoodPrice + catFoodPrice} lv.");


        }
    }
}
