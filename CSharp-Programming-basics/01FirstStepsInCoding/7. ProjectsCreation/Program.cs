using System;

namespace Test2
{
    class Program
    {
        static void Main(string[] args)
        {

            string architectName = Console.ReadLine();
            int projectsNum = int.Parse(Console.ReadLine());

            int projectTime = 3 * projectsNum;

            Console.WriteLine($"The architect {architectName} will need {projectTime} hours to complete {projectsNum} project/s.");

        }
    }
}
