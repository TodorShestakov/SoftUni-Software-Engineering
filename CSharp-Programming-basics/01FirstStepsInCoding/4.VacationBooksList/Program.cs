using System;

namespace Test2
{
    class Program
    {
        static void Main(string[] args)
        {

            int numberOfPagesPerBook = int.Parse(Console.ReadLine());
            int pagesReadPerHour = int.Parse(Console.ReadLine());
            int numberOfDaysToReadTheBook = int.Parse(Console.ReadLine());

            int hourstoreadtheBook = numberOfPagesPerBook / pagesReadPerHour;
            int hoursperDay = hourstoreadtheBook / numberOfDaysToReadTheBook;

//Метод 2
//int hoursperDay = ((numberOfPagesPerBook / pagesReadPerHour) / numberOfDaysToReadTheBook);

            Console.WriteLine(hoursperDay);

        }
    }
}
