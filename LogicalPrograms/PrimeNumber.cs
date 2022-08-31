using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class PrimeNumber
    {
        public static void PrimeNo()
        {
            Console.WriteLine("Enter the Number: ");
            int n = Convert.ToInt32(Console.ReadLine()); //n=15
            int i;
            int isPrime = 1;

            for (i = 2; i <= n / 2; i++)  // 2 <=7 //3 <=7
            {
                if (n % i == 0)
                {
                    isPrime = 0;
                    Console.WriteLine("Number is Not Prime");
                    break;
                }

            }


            if (isPrime == 1)

            {
                Console.WriteLine("Number is Prime");
            }
        }
    }
}
