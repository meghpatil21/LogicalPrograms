﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class ReverseNumber
    {
        public static void RevNo()
        {
            int reverse = 0, rem;
            Console.WriteLine("Enter a number: ");
            int n = int.Parse(Console.ReadLine());
            while (n != 0)
            {
                rem = n % 10;
                reverse = reverse * 10 + rem;
                n = n / 10;
            }
            Console.WriteLine("Reversed Number: " + reverse);
        }
    }
}
