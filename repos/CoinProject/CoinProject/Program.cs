using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinProject
{
    class Program
    {

        decimal note100 = 100;
        decimal note50 = 50;
        decimal note20 = 20;
        decimal note10 = 10;
        decimal note5 = 5;
        decimal coin100 = 1;
        decimal coin50 = 0.5m;
        decimal coin20 = 0.2m;
        decimal coin10 = 0.1m;
        decimal coin5 = 0.05m;
        decimal coin2 = 0.02m;
        decimal coin1 = 0.01m;


        static void Main(string[] args)
        {
            Program cp = new Program();

            cp.ChangeGiver();
        }

        public void ChangeGiver()
        {
            

            Console.WriteLine("Enter cost.");
            decimal cost = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("What has customer paid with?");
            Console.WriteLine("1. £100 note");
            Console.WriteLine("2. £50 note");
            Console.WriteLine("3. £20 note");
            Console.WriteLine("4. £10 note");
            Console.WriteLine("5. £5 note");

            int noteUsed = Convert.ToInt32(Console.ReadLine());

            switch (noteUsed) {
                case 1:
                    if (cost > note100)
                    {
                        Console.WriteLine("Insufficient Funds");
                        ChangeGiver();
                    } else { ChangeLogic(note100, cost); }
                    break;
                case 2:
                    if (cost > note50)
                    {
                        Console.WriteLine("Insufficient Funds");
                        ChangeGiver();
                    } else { ChangeLogic(note50, cost); }
                    break;
                case 3:
                    if (cost > note20)
                    {
                        Console.WriteLine("Insufficient Funds");
                        ChangeGiver();
                    } else { ChangeLogic(note20, cost); }
                    break;
                case 4:
                    if (cost > note10)
                    {
                        Console.WriteLine("Insufficient Funds");
                        ChangeGiver();
                    } else { ChangeLogic(note10, cost); }
                    break;
                case 5:
                    if (cost > note5)
                    {
                        Console.WriteLine("Insufficient Funds");
                        ChangeGiver();
                    } else { ChangeLogic(note5, cost); }
                    break;
            }

            

        }

        public void ChangeLogic(decimal note, decimal cost)
        {
            decimal change = note - cost;
            Console.WriteLine("\nChange Due: " + change);

            if (change >= note100)
            {
                decimal many = change / note100;
                change = change - (note100 * Math.Truncate(many));
                Console.WriteLine(Math.Truncate(many) + " £100 note");
            }
            if (change >= note50)
            {
                decimal many = change / note50;
                change = change - (note50 * Math.Truncate(many));
                Console.WriteLine(Math.Truncate(many) + " £50 note");
            }
            if (change >= note20)
            {
                decimal many = change / note20;
                change = change - (note20 * Math.Truncate(many));
                Console.WriteLine(Math.Truncate(many) + " £20 note");
            }
            if (change >= note10)
            {
                decimal many = change / note10;
                change = change - (note10 * Math.Truncate(many));
                Console.WriteLine(Math.Truncate(many).ToString() + " £10 note");
            }
            if (change >= note5)
            {
                decimal many = change / note5;
                change = change - (note5 * Math.Truncate(many));
                Console.WriteLine(Math.Truncate(many) + " £5 note");
            }
            if (change >= coin100)
            {
                decimal many = change / coin100;
                change = change - (coin100 * Math.Truncate(many));
                Console.WriteLine(Math.Truncate(many) + " £1 coin");
            }
            if (change >= coin50)
            {
                decimal many = change / coin50;
                change = change - (coin50 * Math.Truncate(many));
                Console.WriteLine(Math.Truncate(many) + " 50p coin");
            }
            if (change >= coin20)
            {
                decimal many = change / coin20;
                change = change - (coin20 * Math.Truncate(many));
                Console.WriteLine(Math.Truncate(many) + " 20p coin");
            }
            if (change >= coin10)
            {
                decimal many = change / coin10;
                change = change - (coin10 * Math.Truncate(many));
                Console.WriteLine(Math.Truncate(many) + " 10p coin");
            }
            if (change >= coin5)
            {
                decimal many = change / coin5;
                change = change - (coin5 * Math.Truncate(many));
                Console.WriteLine(Math.Truncate(many) + " 5p coin");
            }
            if (change >= coin2)
            {
                decimal many = change / coin2;
                change = change - (coin2 * Math.Truncate(many));
                Console.WriteLine(Math.Truncate(many) + " 2p coin");
            }
            if (change >= coin1)
            {
                decimal many = change / coin1;
                change = change - (coin1 * Math.Truncate(many));
                Console.WriteLine(Math.Truncate(many) + " 1p coin");
            }
            Console.WriteLine();
        }
    }
}
