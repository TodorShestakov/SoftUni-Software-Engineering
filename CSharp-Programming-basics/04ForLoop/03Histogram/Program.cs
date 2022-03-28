using System;

namespace _3._Histogram
{
    class Program
    {
        static void Main(string[] args)
        {

            int numberOfRows = int.Parse(Console.ReadLine());

            double num1 = 0;
            double num2 = 0;
            double num3 = 0;
            double num4 = 0;
            double num5 = 0;

            for (int i = 1; i <= numberOfRows; i++)
            {
                double currentNumber = double.Parse(Console.ReadLine());
                if (currentNumber < 200)
                {
                    num1++;
                }
                else if (currentNumber >= 200 && currentNumber <= 399)
                {
                    num2++;
                }
                else if (currentNumber >= 400 && currentNumber <= 599)
                {
                    num3++;
                }
                else if (currentNumber >= 600 && currentNumber <= 799)
                {
                    num4++;
                }
                else if (currentNumber >= 800)
                {
                    num5++;
                }
            }

            num1 = num1 / numberOfRows * 100;
            num2 = num2 / numberOfRows * 100;
            num3 = num3 / numberOfRows * 100;
            num4 = num4 / numberOfRows * 100;
            num5 = num5 / numberOfRows * 100;

            Console.WriteLine($"{num1:f2}%");
            Console.WriteLine($"{num2:f2}%");
            Console.WriteLine($"{num3:f2}%");
            Console.WriteLine($"{num4:f2}%");
            Console.WriteLine($"{num5:f2}%");



        }
    }
}
