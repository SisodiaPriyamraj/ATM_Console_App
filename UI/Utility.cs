using System;

namespace ATMApp.UI
{
    public static class Utility
    {
        public static void PressEnterToContinue()
        {
            Console.WriteLine("\nPress Enter to continue");
            Console.ReadLine();
        }

        public static string GetUserInput(string prompt)
        {
            Console.WriteLine($"Enter {prompt}");
            return Console.ReadLine();
        }

        public static void PrintMessage(string msg, bool success)
        {
            if (success == true) 
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            Console.WriteLine(msg);
            Console.ForegroundColor = ConsoleColor.White;
            PressEnterToContinue();
        }
    }
}
