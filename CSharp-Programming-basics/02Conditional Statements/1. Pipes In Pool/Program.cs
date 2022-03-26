using System;

namespace _1._Pipes_In_Pool
{
    class Program
    {
        static void Main(string[] args)
        {
            int vPool = int.Parse(Console.ReadLine());
            int debitPipe1 = int.Parse(Console.ReadLine());
            int debitPipe2 = int.Parse(Console.ReadLine());
            double hoursWorkerOut = double.Parse(Console.ReadLine());

            double pipe1FILL = debitPipe1 * hoursWorkerOut;
            double pipe2FILL = debitPipe2 * hoursWorkerOut;
            double totalFill = pipe1FILL + pipe2FILL;

            double totalFillPercent = ((pipe1FILL + pipe2FILL) / vPool) * 100;
            double pipe1Percent = (pipe1FILL / totalFill) * 100;
            double pipe2Percent = (pipe2FILL / totalFill) * 100;

            double vPoolPercent = (vPool / vPool) * 100;
            double overFlow = Math.Abs(vPool - totalFill);

            if (totalFillPercent <= vPoolPercent)
            {
                Console.WriteLine($"The pool is {totalFillPercent:f2}% full. Pipe 1: {pipe1Percent:f2}%. Pipe 2: {pipe2Percent:f2}%.");
            }
            else
            {
                Console.WriteLine($"For {hoursWorkerOut:f2} hours the pool overflows with {overFlow:f2} liters.");
            }
        }
    }
}
