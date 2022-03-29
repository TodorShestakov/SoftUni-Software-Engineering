using System;

namespace _2._Exam_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {

            int failedGradesTreshhold = int.Parse(Console.ReadLine());

            int failedTimes = 0;
            int solvedProblemsCount = 0;
            double gradesSum = 0;
            string lastProblem = "";
            bool stop = true;



            while (failedTimes < failedGradesTreshhold)
            {
                string problemName = Console.ReadLine();

                if (problemName == "Enough")
                {
                    stop = false;
                    break;
                }

                int grade = int.Parse(Console.ReadLine());

                if (grade <= 4)
                {
                    failedTimes++;
                }

                gradesSum += grade;
                solvedProblemsCount++;
                lastProblem = problemName;                               
            }

            double averageGrade = gradesSum / solvedProblemsCount;



            if (stop)
            {
                Console.WriteLine($"You need a break, {failedGradesTreshhold} poor grades.");
            }
            else
            {
                Console.WriteLine($"Average score: {averageGrade}");
                Console.WriteLine($"Number of problems: {solvedProblemsCount}");
                Console.WriteLine($"Last problem: {lastProblem}");
            }

            //double sumGrades = 0;
            //int problems = 0;
            //string lastProblem = string.Empty;
            //int badGradesCounter = 0;
            //string currProblem = Console.ReadLine();

            //while (currProblem != "Enough")
            //{
            //    lastProblem = currProblem;
            //    double currGrade = double.Parse(Console.ReadLine());

            //    sumGrades += currGrade;
            //    problems++;

            //    if (currGrade <= 4.00)
            //    {
            //        badGradesCounter++;
            //    }
            //    if (badGradesCounter == numBadGrades)
            //    {
            //        Console.WriteLine("You need a break, {0} poor grades.", badGradesCounter);
            //        return;
            //    }
            //    currProblem = Console.ReadLine();
            //}
            //Console.WriteLine("Average score: {0:f2}", sumGrades / problems);
            //Console.WriteLine("Number of problems: {0}", problems);
            //Console.WriteLine("Last problem: {0}", lastProblem);


        }
    }
}
