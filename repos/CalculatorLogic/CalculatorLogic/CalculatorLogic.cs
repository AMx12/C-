using System;

namespace Calculator
{
    public class CalculatorLogics
    {
        public decimal CalculatorOperation(decimal num1, decimal num2, string operation)
        {
            switch (operation)
            {
                case "+":
                    return num1 + num2;
                case "-":
                    return num1 - num2;
                case "*":
                    return num1 * num2;
                case "/":
                    return num1 / num2;
                case "c":
                    return 0;
                default:
                    Console.WriteLine("Not a valid operator.");
                    return 1312;
            }
        }
    }

}
