using System;

namespace Test2
{
    class Program
    {
        static void Main(string[] args)
        {


            double r = double.Parse(Console.ReadLine());


            double liceKryg = Math.PI * r * r;

            double perimetyrKryg = 2 * Math.PI * r;


            Console.WriteLine($"{liceKryg:f2}");

            Console.WriteLine($"{perimetyrKryg:f2}");

        }
    }
}
