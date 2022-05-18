using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace LogicalProgram
{
    internal class StopwatchTimeCalcu
    {
        public void StopwatchCal()
        {

            Stopwatch stopw = new Stopwatch();
            Console.WriteLine("Press START");
            Console.ReadLine();
            stopw.Start();
            Console.WriteLine("Press STOP");
            Console.ReadLine();
            stopw.Stop();
            Console.WriteLine(" Time elapsed: {0} ", stopw.Elapsed);
            Console.WriteLine("Elapsed Time is {0} sec", stopw.Elapsed.Seconds);
        }
    }
}
