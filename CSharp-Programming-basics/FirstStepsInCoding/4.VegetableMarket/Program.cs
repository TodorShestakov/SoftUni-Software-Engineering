using System;

namespace _4.VegetableMarket
{
    class Program
    {
        static void Main(string[] args)
        {


            double vegePrice = double.Parse(Console.ReadLine());
            double fruitsPrice = double.Parse(Console.ReadLine());

            int vegeKG = int.Parse(Console.ReadLine());
            int fruitsKG = int.Parse(Console.ReadLine());

            //duble eur = double.Parse(Console.ReadLine());


            //double bgn = 1.94 * bgn;

            double incomebgn = vegePrice * vegeKG + fruitsPrice * fruitsKG;
            double incomeeur = incomebgn / 1.94;


            Console.WriteLine($"{incomeeur:f2}");
            //Console.WriteLine(Math.Round(incomeeur,2));




        }
    }
}
