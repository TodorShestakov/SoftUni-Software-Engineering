using System;

namespace _1.USDtoBGN
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double usd = double.Parse(Console.ReadLine ());

            double bgnValue = usd * 1.79549;

            Console.WriteLine(bgnValue);


        }
    }
}
