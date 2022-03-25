using System;

namespace Test2
{
    class Program
    {
        static void Main(string[] args)
        {


            int packagePensNum = int.Parse(Console.ReadLine());
            int packageMarkersNum = int.Parse(Console.ReadLine());
            int cleaningDetragentLiters = int.Parse(Console.ReadLine());
            int discountPercentile = int.Parse(Console.ReadLine());

            double penPrice = packagePensNum * 5.8;
            double markerPrice = packageMarkersNum * 7.2;
            double detragentPrice = cleaningDetragentLiters * 1.2;

            double totalPrice = penPrice + markerPrice + detragentPrice;
            //double discount = totalPrice * 0.25;
            //double finalPrice = totalPrice - discount;
            //Console.WriteLine(finalPrice);

            totalPrice = totalPrice - (discountPercentile / 100.0) * totalPrice;

            Console.WriteLine(totalPrice);

        }
    }
}
