using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Program bc = new Program();
            //                            guide 00000000
           Console.WriteLine(bc.BinaryDecimal("10110001"));
            bc.DecimalBinary();
        }

        public int BinaryDecimal(string binary)
        {
            char[] binaryArray = binary.ToCharArray();
            Array.Reverse(binaryArray);
            string input = new string(binaryArray);

            int sum = 0;
            int number = 1;
  
            for(int i = 0; i < 8; i++)
            {
                if(input[i].Equals('1'))
                {
                    sum += number;   
                }

                number += number;
            }

            return sum;
        }

        public void DecimalBinary()
        {
            int bit = 128;
            int number = 177;

            for(int i = 0; i < 8; i++)
            {
                if(number >= bit)
                {
                    Console.Write("1");
                number = number - bit;
                } else
                {
                    Console.Write("0");
                }
                bit = bit / 2;

            }
        }

    }
}
