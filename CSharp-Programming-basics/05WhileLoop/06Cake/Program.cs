using System;

namespace _6._Cake
{
    class Program
    {
        static void Main(string[] args)
        {

            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());

            int allCakePieces = length * width; // колко парчета торта ще имаме



            while (allCakePieces > 0) // докато имаме парчета торта
            {

                string input = Console.ReadLine(); // прочитаме команда
                if (input == "STOP") // ако получим команда стоп
                {
                    break;  // чупим цикъла
                }
                int pieceOfCake = int.Parse(input); // ако не е равна на стоп обаче ще получаваме парче торта
                allCakePieces -= pieceOfCake; // вадим парче торта от общото количество

            }

            if (allCakePieces >= 0) // след като счупим цикъла и сме получили 0 или стоп, проверяваме дали имаме оставащи парчета торта
            {
                Console.WriteLine($"{allCakePieces} pieces are left.");
            }
            else
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(allCakePieces)} pieces more.");
            }


        }
    }
}
