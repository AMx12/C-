using System;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, " + name);
            Console.WriteLine("How many hours of sleep did you get last night " + name + "?");
            int hoursOfSleep = int.Parse(Console.ReadLine());

            if (hoursOfSleep > 8)
            {
                Console.WriteLine("You are well rested!");
            } else if (hoursOfSleep > 4 && hoursOfSleep < 8)
                {
                Console.WriteLine("You are not well rested!");
            }
            else if (hoursOfSleep < 4)
            {
                Console.WriteLine("You need some sleep!!!!");
            }


        }
    }
}
