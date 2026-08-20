using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            UserMessages.WelcomeMessage("Welcome to my Calculator App");

            double x = RequestMessages.GetADouble("Enter first number: ");
            double y = RequestMessages.GetADouble("Enter second number: ");

            string operation = RequestMessages.GetOperation("Enter operation (Add, Subtract, Divide, Multiply): ");

            double result = 0;
            try
            {
                result = CalculatorOperations.PerformOperation(x, y, operation);
            }
            catch (DivideByZeroException ex)
            {
                UserMessages.DisplayResult(ex.Message);   
            }

            UserMessages.DisplayResult($"The result of {operation} is {result}");


            Console.ReadLine();
        }
    }
}
