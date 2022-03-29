using System;

namespace _5._Coins
{
    class Program
    {
        static void Main(string[] args)
        {


            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());

            double allCakePieces = length * width;

            while (allCakePieces > 0)
            {
                string input = Console.ReadLine();
                if (input == "STOP")
                {
                    break;
                }

                int pieceOfCake = int.Parse(input);
                allCakePieces -= pieceOfCake;
            }

            if (allCakePieces < 0)
            {
                Console.WriteLine("No More");
                Console.WriteLine($"{Math.Abs(allCakePieces)}");
            }
            else if (allCakePieces >= 0)
            {
                Console.WriteLine($"{allCakePieces} pieces are left.");
            }




        }
    }
}
