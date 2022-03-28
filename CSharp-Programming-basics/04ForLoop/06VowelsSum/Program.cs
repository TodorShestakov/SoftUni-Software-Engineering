using System;

namespace _6._Vowels_Sum
{
    class Program
    {
        static void Main(string[] args)
        {

            //string text = Console.ReadLine();
            //int sum = 0;

            //for (int i = 0; i < text.Length; i++)
            //{
            //    char currentSymbol = text[i];

            //    if (currentSymbol == 'a')
            //    {
            //        sum += 1;
            //    }
            //    else if (currentSymbol == 'e')
            //    {
            //        sum += 2;
            //    }
            //    else if (currentSymbol == 'i')
            //    {
            //        sum += 3;
            //    }
            //    else if (currentSymbol == 'o')
            //    {
            //        sum += 4;
            //    }
            //    else if (currentSymbol == 'u')
            //    {
            //        sum += 5;
            //    }
            //}
            
            //Console.WriteLine(sum);


            int suma = 0;
            int sume = 0;
            int sumi = 0;
            int sumo = 0;
            int sumu = 0;
            string s = Console.ReadLine();
            for (int i = 0; i <= s.Length - 1; i++)
            {
                if (s[i] == 'a')
                    suma++;
                else if (s[i] == 'e')
                    sume += 2;
                else if (s[i] == 'i')
                    sumi += 3;
                else if (s[i] == 'o')
                    sumo += 4;
                else if (s[i] == 'u')
                    sumu += 5;
            }
            int ResultSum = suma + sume + sumi + sumo + sumu;
            Console.WriteLine(ResultSum);
        }
    }
}
