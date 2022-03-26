using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("firstName");
            string firstName = Console.ReadLine();
            //Console.WriteLine("lastName");
            string lastName = Console.ReadLine();
            //Console.WriteLine("age");
            int age = int.Parse(Console.ReadLine());
            // Console.WriteLine("town");
            string town = Console.ReadLine();
            Console.WriteLine($"You are {firstName} {lastName}, a {age}-years old person from {town}.");
        }
    }
}
