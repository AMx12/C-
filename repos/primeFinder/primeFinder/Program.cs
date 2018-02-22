using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Collections;

namespace primeFinder
{
    class Program
    {
        public static void Main(string[] args)
        {
            Program pf = new Program();
            Console.WriteLine(pf.OptimusPrime(100));
        }

        public string OptimusPrime(int limit)
        {
            DateTime startTime, endTime;
            startTime = DateTime.Now;

            int counter1 = 0;
            int counter2 = 0;


            for (int i = 2; i < limit; i++)
            {
                counter1 = 0;

                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        counter1++;
                    } else if (counter1 > 2)
                    {
                        break;
                    }

                }
                if (counter1 == 2)
                {
                    counter2++;
                }
                
            }
            endTime = DateTime.Now;
            Double elapsedMillisecs = ((TimeSpan)(endTime - startTime)).TotalMilliseconds;
            return counter2.ToString() + "\nTime Elapsed: " + elapsedMillisecs;
        }


    }
}










