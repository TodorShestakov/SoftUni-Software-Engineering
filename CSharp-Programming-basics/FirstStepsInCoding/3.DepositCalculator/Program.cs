using System;

namespace Test2
{
    class Program
    {
        static void Main(string[] args)
        {
        
//МЕТОД 1 -------------------------------------------------------------------
            double deposit = double.Parse(Console.ReadLine());
            int due = int.Parse(Console.ReadLine());
            double yearInterest = double.Parse(Console.ReadLine());

            //double accruedInterest = deposit * yearInterest / 100;
            //double interestPerMonth = accruedInterest / 12;


            double sum = deposit + due * ((deposit * yearInterest/100) / 12);
            //double sum = deposit + due * interestPerMonth;


            Console.WriteLine(sum);
//---------------------------------------------------------------------------

//МЕТОД 2 -------------------------------------------------------------------
            double deposit = double.Parse(Console.ReadLine());
            int due = int.Parse(Console.ReadLine());
            double yearInterest = double.Parse(Console.ReadLine());

            double accruedInterest = deposit * yearInterest / 100;
            double interestPerMonth = accruedInterest / 12;


            //double sum = deposit + due * ((deposit * yearInterest / 100) / 12);
            double sum = deposit + due * interestPerMonth;
//---------------------------------------------------------------------------



        }
    }
}
