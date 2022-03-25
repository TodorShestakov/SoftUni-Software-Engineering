using System;

namespace _3.CelsiusToFahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {

            double degrees = double.Parse(Console.ReadLine());

            double farenhait = degrees * 1.8 + 32;

            Console.WriteLine($"{farenhait:F2}");


        }
    }
}
