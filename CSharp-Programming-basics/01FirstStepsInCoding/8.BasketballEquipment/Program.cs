using System;

namespace Test2
{
    class Program
    {
        static void Main(string[] args)
        {

            int trainingTax = int.Parse(Console.ReadLine());


            double shoes = trainingTax - (trainingTax * 0.4);
            double clothes = shoes - (shoes * 0.2);
            double ball = clothes / 4;
            double accessoires = ball / 5;


            double totalCost = trainingTax + shoes + clothes + ball + accessoires;

            Console.WriteLine(totalCost);

        }
    }
}
