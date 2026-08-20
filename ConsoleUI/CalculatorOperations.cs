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

            output = x / y;
            
            if (double.IsInfinity(output) == true)
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

        public static double PerformOperation(double x, double y, string operation)
        {
            switch (operation)
            {
                case "add":
                    return Add(x, y);
                    break;
                case "subtract":
                    return Subtract(x, y);
                    break;
                case "multiply":
                    return Multiply(x, y);
                    break;
                case "divide":
                    try
                    {
                        return Divide(x, y);
                    }
                    catch(DivideByZeroException ex)
                    {
                        throw new DivideByZeroException(ex.Message);
                    }
                    break;
                default:
                    return 0;
                    break;
            }
        }
    }
}
