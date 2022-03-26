using System;

namespace Test2
{
    class Program
    {
        static void Main(string[] args)
        {

            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());


            double LiceprednaStena = x * x;
            //вадим от лицето
            double liceVrata = 1.2 * 2;

            double PrednaLice = LiceprednaStena * 2 - liceVrata;

            double liceStranichnaStena = x * y;
            //вадим от лицето *2
            double liceProzorec = 1.5 * 1.5;

            double StranichnaLice = (2 * liceStranichnaStena) - (2 * liceProzorec);

            double liceSteni = PrednaLice + StranichnaLice;

            double liceMalykTriygylnik = (x * h / 2) * 2;


            double LicePravoygylnik = (x * y) * 2;

            double licePokriv = liceMalykTriygylnik + LicePravoygylnik;


            double razhodZelena = liceSteni / 3.4;
            double razhodChervena = licePokriv / 4.3;





            Console.WriteLine($"{razhodZelena:f2}");
            Console.WriteLine($"{razhodChervena:f2}");






        }
    }
}
