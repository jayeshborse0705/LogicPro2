using System;

using System;

namespace LogicalProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter number as per options");
            Console.WriteLine("1: For Flip a coin and find % of Head and Tail");
            Console.WriteLine("2: For checking leap year");
            int check = Convert.ToInt32(Console.ReadLine());
            switch (check)
            {

                case 1:
                    Fibonacci fibonacci = new Fibonacci();
                    fibonacci.FibonacciSeries();
                    break;
                case 2:
                    PerfectNum perfectNum = new PerfectNum();
                    perfectNum.Perfect_Num();
                    break;
                default:
                    Console.WriteLine("Please SELECT correct number ! ");
                    break;

            }
        }
    }
}