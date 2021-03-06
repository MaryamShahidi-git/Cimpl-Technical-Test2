﻿using System;


namespace CalculatorLogic
{
    public class Calculator
    {
        public ConsoleColor color = ConsoleColor.White;

        public double Sum(double a, double b)
        {
            var x = a + b;
            Console.ForegroundColor = color;
            /* I changed this format of code every where in this class because my c# version is 5 and 
              doesn't support the $ - string interpolation. */
            //Console.WriteLine($"The result is: {x}");
            Console.WriteLine("The result is: {0}",x);
            return x;
        }

        public double Subtract(double a, double b)
        {
            var x = a - b;
            Console.ForegroundColor = color;
            Console.WriteLine("The result is: {0}",x);
            return x;
        }

        public double Multiply(double a, double b)
        {
            var x = a * b;
            Console.ForegroundColor = color;
            Console.WriteLine("The result is: {0}",x);
            return x;
        }

        public double Divide(double a, double b)
        {
            var x = a / b;
            Console.ForegroundColor = color;
            Console.WriteLine("The result is: {0}",x);
            return x;
        }
    }
}
