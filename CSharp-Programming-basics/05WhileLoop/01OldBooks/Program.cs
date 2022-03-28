using System;

namespace _5._While_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            //string bookName = Console.ReadLine();

            //string currentBook = Console.ReadLine();

            //int counter = 0;

            //while (currentBook != bookName)
            //{
            //    counter++;
            //    currentBook = Console.ReadLine();

            //    if (currentBook == "No More Books")
            //    {
            //        break;
            //    }
            //}
            //if (currentBook == bookName)
            //{
            //    Console.WriteLine($"You checked {counter} books and found it.");
            //}
            //else if (currentBook != bookName)
            //{
            //    Console.WriteLine($"The book you search is not here!");
            //    Console.WriteLine($"You checked {counter} books.");
            //}


//VAR 2
            string wantedBook = Console.ReadLine();

            string currentBook = Console.ReadLine();
            int counter = 0;

            while (currentBook != "No More Books")
            {

                if (currentBook == wantedBook)
                {
                    Console.WriteLine($"You checked {counter} books and found it.");
                    break;
                }
                counter++;
                currentBook = Console.ReadLine();
            }
            if (currentBook == "No More Books")
            {
                Console.WriteLine($"The book you search is not here!");
                Console.WriteLine($"You checked {counter} books.");
            }
        }
    }
}
