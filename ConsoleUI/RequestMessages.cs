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
            bool isStringEmpty;

            do
            {
                Console.Write(message);
                operation = Console.ReadLine();
                isStringEmpty = String.IsNullOrEmpty(operation);

            } while (isStringEmpty == true);

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
