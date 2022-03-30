using System;

namespace _4._Train_The_Trainers
{
    class Program
    {
        static void Main(string[] args)
        {


            int juryCount = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();

            int gradeCount = 0;
            double sumOfAllGrades = 0;

            while (input != "Finish")
            {
                double sumOfGrades = 0;
                for (int i = 1; i <= juryCount; i++)
                {
                    double grade = double.Parse(Console.ReadLine());
                    sumOfGrades += grade;
                    gradeCount++;
                    sumOfAllGrades += grade;
                }
                double averageForCurrentPresentation = sumOfGrades / juryCount;
                Console.WriteLine($"{input} - {averageForCurrentPresentation:f2}.");
                input = Console.ReadLine();
            }

            double finalAverageGrade = sumOfAllGrades / gradeCount;
            Console.WriteLine($"Student's final assessment is {finalAverageGrade:f2}.");
        }
    }
}
