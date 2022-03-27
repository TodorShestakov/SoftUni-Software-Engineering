using System;

namespace _8._Fuel_Tank
{
    class Program
    {
        static void Main(string[] args)
        {

            string fuelType = Console.ReadLine();
            double liters = double.Parse(Console.ReadLine());


            if (fuelType == "Diesel" && liters < 25)
            {
                Console.WriteLine($"Fill your tank with {"diesel"}!");
            }
            else if (fuelType == "Diesel" && liters >= 25)
            {
                Console.WriteLine($"You have enough {"diesel"}.");
            }

            else if (fuelType == "Gasoline" && liters < 25)
            {
                Console.WriteLine($"Fill your tank with {"gasoline"}!");
            }
            else if (fuelType == "Gasoline" && liters >= 25)
            {
                Console.WriteLine($"You have enough {"gasoline"}.");
            }
            else if (fuelType == "Gas" && liters < 25)
            {
                Console.WriteLine($"Fill your tank with {"gas"}!");
            }
            else if (fuelType == "Gas" && liters >= 25)
            {
                Console.WriteLine($"You have enough {"gas"}.");
            }
            else if ((fuelType != "Gas") && (fuelType != "Gasoline") && (fuelType != "Diesel")) 
            {
                Console.WriteLine($"Invalid fuel!");
            }



        }
    }
}
