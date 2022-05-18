using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalProgram
{
    internal class Coupon
    {
        public int Generator()
        {
            Random random = new Random();
            return random.Next(1000, 10000);

        }
        public void CouponGen()
        {
            Console.WriteLine("Coupon numbers between 1000 to 9999");
            Console.WriteLine("Enter How many coupon number Do you want to generate");
            int N = Convert.ToInt32(Console.ReadLine());
            int[] CouponNumbers = new int[N];
            int CouponNum = Generator();
            if (N > 9000)
            {
                Console.WriteLine("Sorry, only 9000 different coupon numbers can generate");
            }
            else
            {
                for (int i = 0; i < N; i++)
                {
                    while (Array.Exists(CouponNumbers, element => element == CouponNum))
                    {
                        CouponNum = Generator();
                    }
                    CouponNumbers[i] = CouponNum;
                }
                Console.WriteLine("Coupon Numbers are: ");
                for (int i = 0; i < N; i++)
                {
                    Console.WriteLine(CouponNumbers[i]);
                }
            }
        }
    }
}
