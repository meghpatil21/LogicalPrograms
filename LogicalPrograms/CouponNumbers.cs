using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class CouponNumbers
    {
        public static void CoupnNo()
        {
            Console.WriteLine("Enter how many coupon number: ");
            int n=Convert.ToInt32(Console.ReadLine());
            int count = 0;
            int mem = 0;
            int totalRandom = 0;
            Console.WriteLine();
            while(n!=count)
            {
                Random random = new Random();
                int CoupnNo=random.Next(1,9);
                totalRandom++;

                if(CoupnNo!=mem)
                {
                    Console.WriteLine(CoupnNo);
                    mem = CoupnNo;
                    count++;
                }

            }
            Console.WriteLine($"Total Random number needed to generate non-repeated {n} coupons number is {totalRandom}");
            
        }
    }
}
