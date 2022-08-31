using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class FinonacciSeries
    {
        public static void FibSeries()
        {
            int n1 = 0;
            int n2 = 1;
            int n3, i, number;
            Console.Write("Enter the number of fibonacci units: ");
            number =Convert.ToInt32(Console.ReadLine());

            Console.Write(n1 + " " + n2 + " ");    
            for (i = 2; i < number; ++i)    
            {
                n3 = n1 + n2;
                Console.Write(n3 + " ");
                n1 = n2;
                n2 = n3;
            }
        }
    }
}
