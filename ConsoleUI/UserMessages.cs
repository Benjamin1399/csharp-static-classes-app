using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public static class UserMessages
    {
        public static void WelcomeMessage(string message)
        {
            Console.Write(message);
        }

        public static void DisplayResult(string message)
        {
            try
            {
                Console.Write(message);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
