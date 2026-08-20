using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public static class RequestMessages
    {
        public static string GetOperation(string message)
        {
            string operation;
            bool isStringValid;

            do
            {
                Console.Write(message);
                operation = Console.ReadLine();
                isStringValid = String.IsNullOrEmpty(operation);

            } while (isStringValid == false);

            return operation.ToLower();
        }

        public static double GetADouble(string message)
        {
            string input;
            double number;
            bool isValidDouble;

            do
            {
                Console.Write(message);
                input = Console.ReadLine();

                isValidDouble = double.TryParse(input, out number);

            }
            while (isValidDouble == false);

            return number;
        }
    }
}
