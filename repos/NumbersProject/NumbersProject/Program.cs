using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AddInts());
            TypeIntName();
        }


        public static int AddInts()
        {
            Console.WriteLine("Enter a number");
            string input = Console.ReadLine();

            int sum = 0;

            for (int i =0; i < input.Length; i++)
            {
                sum += (Convert.ToInt32(input[i]) - 48);
            }

            return sum;
        }

        public static void TypeIntName()
        {
            Console.WriteLine("Enter a number");
            string number = Console.ReadLine();
            char[] numberArray = number.ToCharArray();
            Array.Reverse(numberArray);
            string input = new string (numberArray);

            string first = "";
            string second = "";
            string third = "";
            string fourth = "";

            Dictionary<int, string> units = new Dictionary< int, string>();
            Dictionary<int, string> tens = new Dictionary<int, string>();
            Dictionary<int, string> teens = new Dictionary<int, string>();
            Dictionary<int, string> thous = new Dictionary<int, string>();

            units.Add(0, "zero");
            units.Add(1, "one");
            units.Add(2, "two");
            units.Add(3, "three");
            units.Add(4, "four");
            units.Add(5, "five");
            units.Add(6, "six");
            units.Add(7, "seven");
            units.Add(8, "eight");
            units.Add(9, "nine");

            tens.Add(0, "");
            tens.Add(1, "ten");
            tens.Add(2, "twenty-");
            tens.Add(3, "thirty-");
            tens.Add(4, "fourty-");
            tens.Add(5, "fifty-");
            tens.Add(6, "sixty-");
            tens.Add(7, "seventy-");
            tens.Add(8, "eighty-");
            tens.Add(9, "ninety-");

            teens.Add(11, "eleven");
            teens.Add(12, "twelve");
            teens.Add(13, "thirteen");
            teens.Add(14, "fourteen");
            teens.Add(15, "fifteen");
            teens.Add(16, "sixteen");
            teens.Add(17, "seventeen");
            teens.Add(18, "eighteen");
            teens.Add(19, "nineteen");

            first = units[Convert.ToInt32(input[0]) - 48];

            if (input.Length > 1) { 
            
                if (Convert.ToInt32(input[0]) - 48 == 0)
                {
                    first = "";
                }
                second = tens[Convert.ToInt32(input[1]) - 48];
            }

            if (input.Length > 2)
            { 
                if (Convert.ToInt32(input[1]) - 48 == 0)
                {
                    second = "";
                }
                third = units[Convert.ToInt32(input[2]) - 48] + " hundred ";
            }

            if (input.Length > 3)
            { 
                if (Convert.ToInt32(input[2]) - 48 == 0)
                {
                    third = "";
                }
                fourth = units[Convert.ToInt32(input[3]) - 48] + " thousand ";

                if (Convert.ToInt32(input[3]) - 48 == 0)
                {
                    fourth = "";
                }

            }

            foreach(var teen in teens)
            {
                if (teen.Key == Convert.ToInt32(input[1] + "" + input[0]))
                {
                    second = teen.Value;
                    first = "";
                }
            }

            Console.WriteLine(fourth + third + second + first);

        }
    }
}
