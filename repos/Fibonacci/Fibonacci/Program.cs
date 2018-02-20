using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Program fb = new Program();
            fb.Fibonacci(14);
        }

        public void Fibonacci(int times)
        {
            int num1 = 0;
            int num2 = 1;
            int num3;

            Console.WriteLine(num1 + "\n" + num2);
            for(int i = 0; i < times - 1; i++)
            {
                num3 = num1 + num2;
                Console.WriteLine(num3);
                num1 = num2;
                num2 = num3;
            }

        }
    }
}
