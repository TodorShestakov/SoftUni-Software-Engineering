﻿using System;

namespace _6._Building
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfFloors = int.Parse(Console.ReadLine());
            int numberOfRooms = int.Parse(Console.ReadLine());




            for (int floor = numberOfFloors; floor >= 1; floor--)
            {
                for (int room = 0; room < numberOfRooms; room++)
                {
                    if (floor == numberOfFloors)
                    {
                        Console.Write($"L{floor}{room} ");
                        continue;
                    }

                    if (floor % 2 == 0)
                    {
                        Console.Write($"O{floor}{room} ");
                    }
                    else
                    {
                        Console.Write($"A{floor}{room} ");
                    }
                }

                Console.WriteLine();   // отпечатва всички стаи от един етаж на един ред и след това минава на нов ред за другите стаи от втория етаж
            }






        }
    }
}
