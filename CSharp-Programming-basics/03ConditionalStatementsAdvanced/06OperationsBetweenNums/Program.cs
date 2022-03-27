using System;

namespace _6.OperationsBetweenNums
{
    class Program
    {
        static void Main(string[] args)
        {


            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            string operatoR = Console.ReadLine();

            double operation = 0;

            if (operatoR == "+")
            {
                operation = n1 + n2;
                if (operation % 2 == 0)
                {
                    Console.WriteLine($"{n1} + {n2} = {operation} - even");
                }
                else
                {
                    Console.WriteLine($"{n1} + {n2} = {operation} - odd");
                }
            }
            else if (operatoR == "-")
            {
                operation = n1 - n2;
                if (operation % 2 == 0)
                {
                    Console.WriteLine($"{n1} - {n2} = {operation} - even");
                }
                else
                {
                    Console.WriteLine($"{n1} - {n2} = {operation} - odd");
                }
            }
            else if (operatoR == "*")
            {
                operation = n1 * n2;
                if (operation % 2 == 0)
                {
                    Console.WriteLine($"{n1} * {n2} = {operation} - even");
                }
                else
                {
                    Console.WriteLine($"{n1} * {n2} = {operation} - odd");
                }
            }
            else if (operatoR == "/")
            {
                if (n2 != 0)
                {
                    operation = n1 / n2;
                    Console.WriteLine($"{n1} / {n2} = {n1 * 1.0 / n2:F2}");
                }
                else
                {
                    Console.WriteLine($"Cannot divide {n1} by zero");
                }
                
            }
            else if (operatoR == "%")
            {
                if (n2 != 0)
                {
                    operation = n1 % n2;
                    Console.WriteLine($"{n1} % {n2} = {operation}");
                }
                else
                {
                    Console.WriteLine($"Cannot divide {n1} by zero");
                }
            }
            
        }
    }
}
