using System;

namespace _7.Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {

            string figure = Console.ReadLine();

            double result = 0;

            if (figure == "square")
            {
                double a = double.Parse(Console.ReadLine());
                result = a * a;
            }

            else if (figure == "rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                result = a * b;
            }

            else if (figure == "circle")
            {
                double r = double.Parse(Console.ReadLine());
                result = Math.PI * r * r;

            }

            else if (figure == "triangle")
            {
                double a = double.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());
                result = (a * h) / 2;
            }


            Console.WriteLine($"{result:f3}");


        }
    }
}
