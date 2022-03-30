using System;

namespace Nested_loops
{
    class Program
    {
        static void Main(string[] args)
        {


            int targetNum = int.Parse(Console.ReadLine());

            int row = 1;
            int currNum = 1;
            bool isEqual = false;

            while (isEqual == false)
            {
                for (int i = 1; i <= row; i++)
                {
                    Console.Write($"{currNum} ");
                    currNum++;
                    if (currNum > targetNum)
                    {
                        isEqual = true;
                        break;
                    }
                }
                Console.WriteLine();
                row++;
            }


            //int targetNum = int.Parse(Console.ReadLine());

            //int counter = 1;

            //for (int i = 0; i < targetNum; i++)
            //{

            //    for (int j = 0; j <= i; j++)
            //    {
            //        Console.Write($"{counter} ");
            //        if (counter == targetNum)
            //        {
            //            return;
            //        }
            //        counter++;
            //    }

            //    Console.WriteLine();
            //}
        }
    }
}
