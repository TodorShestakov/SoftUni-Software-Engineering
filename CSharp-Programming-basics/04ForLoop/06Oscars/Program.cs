using System;

namespace _6._Oscars
{
    class Program
    {
        static void Main(string[] args)
        {

            string actorName = Console.ReadLine();
            double startingPoints = double.Parse(Console.ReadLine());
            int judgesCount = int.Parse(Console.ReadLine());

            double totalPoints = startingPoints;

            for (int i = 0; i < judgesCount; i++)
            {
                string judge = Console.ReadLine();
                double points = double.Parse(Console.ReadLine());


                double momentPoints = (judge.Length * points) / 2;
                totalPoints += momentPoints;

                if (totalPoints >= 1250.5)
                {
                    break;
                }

            }

            double diff = Math.Abs(totalPoints - 1250.5);

            if (totalPoints >= 1250.5)
            {
                Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {totalPoints:f1}!");
            }


            else if (totalPoints <= 1250.5)
            {
                Console.WriteLine($"Sorry, {actorName} you need {diff:f1} more!");
            }


        }
    }
}
