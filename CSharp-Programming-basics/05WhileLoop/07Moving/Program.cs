using System;

namespace _7._Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            int freeSpace = length * width * height; // свободно пространство

            int sumOfCubicMeters = 0; // правим променлива за кубичните сантиметри, които събираме и сравняваме със свободното пространство

            string command = Console.ReadLine(); // четем първата команда от конзолата


            while (command != "Done")  // докато командата е различна от done
            {
                int currentCubicMeters = int.Parse(command); // щом не е done значи получавам сантиметри (парсвам)
                sumOfCubicMeters += currentCubicMeters; // добавям ги към сумата от кобични сантиметри
                if (freeSpace < sumOfCubicMeters) // ако нямам останало свободно място
                {
                    int neededCubicMeters = sumOfCubicMeters - freeSpace; // изчисляваме разликата
                    Console.WriteLine($"No more free space! You need {neededCubicMeters} Cubic meters more.");
                    break; // излизаме навън и проверяваме
                }

                command = Console.ReadLine();
            }
            if (command == "Done")
            {
                int freeCubicMeters = freeSpace - sumOfCubicMeters;
                Console.WriteLine($"{freeCubicMeters} Cubic meters left.");
            }
            
        }
    }
}
