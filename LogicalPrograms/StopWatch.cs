using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class StopWatchChk
    {
        public static void StpWtch()
        {
            Stopwatch stopwatch=new Stopwatch();
            Console.WriteLine("Enter to start Stopwatch");
            Console.ReadLine();
            stopwatch.Start();

            Console.WriteLine("Enter to stop Stopwatch");
            Console.ReadLine();
            stopwatch.Stop();
           
            Console.WriteLine("Time Elapsed : {0}",stopwatch.Elapsed);
        }
    }
}
