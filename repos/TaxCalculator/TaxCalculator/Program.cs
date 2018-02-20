using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCalculator
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your salary.");
            int salary = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("£" + ReturnAmount(salary, ReturnPercentage(salary)));



        }

        public static int ReturnPercentage(int salary)
        {
                    if (salary <= 14999)
                    {
                        return 0;
                    } else if (15000 <= salary && salary <= 19999)
                    {
                        return 10;
                    } else if (20000 <= salary && salary <= 29999)
                    {
                        return 15;
                    } else if (30000 <= salary && salary <= 44999)
                    {
                        return 20;
                    } else if (salary >= 45000)
                    {
                        return 25;
                    }
             return 99;
        }

        public static string ReturnAmount(int salary, int tax)
        {

            if (tax == 0)
            {
                return salary.ToString() + " Tax: " + tax + "% Amount: £0";
            }
            else if (tax == 10)
            {
                return salary.ToString() + " Tax: " + tax + "% Amount: £" + (salary / 100) * 10;
            }
            else if (tax == 15)
            {
                return salary.ToString() + " Tax: " + tax + "% Amount: £" + (salary / 100) * 15;
            }
            else if (tax == 20)
            {
                return salary.ToString() + " Tax: " + tax + "% Amount: £" + (salary / 100) * 20;
            }
            else if (tax == 25)
            {
                return salary.ToString() + " Tax: " + tax + "% Amount: £" + (salary / 100) * 25;
            }

            return "You messed up.";
        }

    }
}
