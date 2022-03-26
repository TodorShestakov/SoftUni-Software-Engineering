using System;

namespace Test2
{
    class Program
    {
        static void Main(string[] args)
        {


            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double percentOccupied = double.Parse(Console.ReadLine());

            double capacityLiters = (length * width * height) / 1000;

            double extraStuff = capacityLiters * (percentOccupied / 100);

            double litersInTank = (capacityLiters - extraStuff);

            Console.WriteLine(litersInTank);



        }
    }
}
