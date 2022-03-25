using System;

namespace _5.TrainingLab
{
    class Program
    {
        static void Main(string[] args)
        {


            double w = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            //double result = 0;
            double wFloor = w * 100;
            double hFloor = 100;

            double wTable = 70;
            double hTable = 120;



            double workPlaceH = Math.Floor((h * 100 - 100) / 70);
            double workPlaceW = Math.Floor(w * 100 / 120);
            double workPlace = workPlaceW * workPlaceH - 3;


            Console.WriteLine(workPlace);





        }
    }
}
