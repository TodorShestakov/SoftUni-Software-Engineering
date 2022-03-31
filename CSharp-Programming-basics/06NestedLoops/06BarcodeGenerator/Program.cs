using System;

namespace _6._Barcode_Generator__Exam_
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

                                                 //2345
                                                 //6789


            int fourthDigitFromNum1 = num1 % 10; // 5           // извеждаме последната цифра от вход 1 
            int fourthDigitFromNum2 = num2 % 10; // 9           // извеждаме последната цифра от вход 2 
            num1 /= 10;  //234                                  // премахваме последната цифра от вход 1  
            num2 /= 10;  //678                                  // премахваме последната цифра от вход 2   

            int thirdDigitFromNum1 = num1 % 10;  //4
            int thirdDigitFromNum2 = num2 % 10;  //8
            num1 /= 10;   //23
            num2 /= 10;   //67

            int secondDigitFromNum1 = num1 % 10; //3
            int secondDigitFromNum2 = num2 % 10; //7
            num1 /= 10; //2
            num2 /= 10; //6


            for (int i = num1; i <= num2; i++)
            {
                for (int j = secondDigitFromNum1; j <= secondDigitFromNum2; j++)
                {
                    for (int k = thirdDigitFromNum1; k <= thirdDigitFromNum2; k++)
                    {
                        for (int l = fourthDigitFromNum1; l <= fourthDigitFromNum2; l++)
                        {
                            if (l % 2 != 0 && k % 2 != 0 && j % 2 != 0 && i % 2 != 0)
                            {
                                Console.Write($"{i}{j}{k}{l} ");
                            }
                        }
                    }
                }
            }

        }
    }
}
