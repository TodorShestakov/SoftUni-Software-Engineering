using System;

namespace Test2
{
    class Program
    {
        static void Main(string[] args)
        {

            int nailon = int.Parse(Console.ReadLine());
            int paint = int.Parse(Console.ReadLine());
            int paintThinner = int.Parse(Console.ReadLine());
            int hoursToFinishWork = int.Parse(Console.ReadLine());



//double extraNailon = 2; (вкарват се дйректно в nailonPrice) - > double nailonPrice = (nailon + extraNailon) * 1.5;
//double extraPaint = paint * 0.1; (paintPrice) - > double paintPrice = (paint + extraPaint) * 14.5;

            double nailonPrice = (nailon + 2) * 1.5;
            double paintPrice = (paint + paint * 0.1) * 14.5;
            double paintThinnerPrice = paintThinner * 5;
            double bagPrice = 0.40;
            double totalMaterialsPrice = nailonPrice + paintPrice + paintThinnerPrice + bagPrice;

            double workersPrice = (totalMaterialsPrice * 0.3) * hoursToFinishWork;
            double finalPrice = totalMaterialsPrice + workersPrice;


            Console.WriteLine(finalPrice);



        }
    }
}
