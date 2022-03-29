using System;

namespace _4._Walking
{
    class Program
    {
        static void Main(string[] args)
        {


            int totalSteps = 0;

            while (totalSteps < 10000)
            {

                string input = Console.ReadLine();


                if (input == "Going home")
                {
                    int stepsLeft = int.Parse(Console.ReadLine());
                    totalSteps += stepsLeft;
                    break;
                }

                int currentSteps = int.Parse(input);
                totalSteps += currentSteps;

            }

            if (totalSteps >= 10000)
            {
                Console.WriteLine($"Goal reached! Good job!");
                int stepsOverTheGoal = totalSteps - 10000;
                Console.WriteLine($"{stepsOverTheGoal} steps over the goal!");
            }
            else
            {
                int diff = Math.Abs(totalSteps - 10000);
                Console.WriteLine($"{diff} more steps to reach goal.");
            }
        }
    }
}
