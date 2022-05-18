using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalProgram
{
    internal class PrimeNumber
    {
        public void PrimeNum()
        {
            Console.WriteLine("Enter the number that you want to check prime number or not");
            int num = Convert.ToInt32(Console.ReadLine());
            int IsPrime = 1;
            if (num <= 1)
            {
                Console.WriteLine("Please enter correct number");

            }
            else
            {
                for (int i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        IsPrime = 0;
                        break;
                    }
                }
                if (IsPrime == 0)
                {
                    Console.WriteLine("The given number {0} is not Prime number", num);
                }
                else
                {
                    Console.WriteLine("The given number {0} is Prime number", num);
                    Console.WriteLine(num);
                }

            }

        }
    }
}
