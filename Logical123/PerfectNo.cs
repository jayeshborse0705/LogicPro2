using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalProgram
{
    internal class PerfectNum
    {
        public void Perfect_Num()
        {
            Console.WriteLine("Enter your number to check it's perfect number or not");
            int Num = Convert.ToInt32(Console.ReadLine());
            int  Sum = 0;
            if (Num <= 0)
            {
                Console.WriteLine("Please enter a correct number");
            }
            else if (Num == 1)
            {
                Console.WriteLine("{0} is not a perfect number", Num);
            }
            else
            {
                for (int i = 1; i <= Num / 2; i++)
                {
                    if (Num % i == 0)
                    {
                        Sum = Sum + i;

                    }
                }

                if (Sum == Num)
                {
                    Console.WriteLine("Yes this number {0} is a perfect number", Num);
                }
                else
                {
                    Console.WriteLine("No this number {0} is not a perfect number", Num);
                }

            }
        }
    }
}
