﻿using System;

namespace _4.Password_Guess
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string text = Console.ReadLine();

            if (text == "s3cr3t!P@ssw0rd")
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }

        }
    }
}
