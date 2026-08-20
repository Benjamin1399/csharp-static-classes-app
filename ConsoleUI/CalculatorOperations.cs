using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public static class CalculatorOperations
    {
        public static double Add(double x, double y)
        {
            double output = x + y;

            return output;
        }

        public static double Subtract(double x, double y)
        {
            double output = x - y;

            return output;
        }

        public static double Divide(double x, double y)
        {
            double output = 0;

            try
            {
                output = x / y;
            }
            catch (DivideByZeroException ex)
            {
                throw new DivideByZeroException("Cannot divide by zero");
            }

            return output;
        }

        public static double Multiply(double x, double y)
        {
            double output = x * y;

            return output;
        }
    }
}
