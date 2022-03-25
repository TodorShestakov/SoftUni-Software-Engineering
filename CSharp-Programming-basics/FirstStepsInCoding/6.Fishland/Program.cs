using System;

namespace Test2
{
    class Program
    {
        static void Main(string[] args)
        {


            double skumriaPrice = double.Parse(Console.ReadLine());
            double cacaPrice = double.Parse(Console.ReadLine());
            double kgPalamud = double.Parse(Console.ReadLine());
            double kgSafrid = double.Parse(Console.ReadLine());
            int kgMidi = int.Parse(Console.ReadLine());

            double palamudPrice = skumriaPrice + (0.6 * skumriaPrice);
            double palamudSum = kgPalamud * palamudPrice;

            double safridPrice = cacaPrice + (0.8 * cacaPrice);
            double safridSum = kgSafrid * safridPrice;

            double midiPrice = 7.5;
            double midiSum = kgMidi * midiPrice;




            double totalPrice = palamudSum + safridSum + midiSum;

            Console.WriteLine($"{totalPrice:f2}");



        }
    }
}
