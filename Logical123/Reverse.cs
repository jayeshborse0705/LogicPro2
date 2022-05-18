using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalProgram
{
    internal class ReverseNumber
    {
        public void ReverseNum()
        {
            Console.WriteLine("Enter your number");
            int num = Convert.ToInt32(Console.ReadLine());
            int Temp = num;
            int Reverse = 0;
            while (num != 0)
            {
                int Remainder = num % 10;
                Reverse = (Reverse * 10) + Remainder;
                num = num / 10;
            }
            Console.WriteLine("Reverse of the number {0} is: {1}", Temp, Reverse);
        }
    }
}