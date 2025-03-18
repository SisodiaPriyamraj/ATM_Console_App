using System;

namespace ATMApp.UI
{
    public static class AppScreen
    {
        internal static void Welcome()
        {
            // sets the title of the the console window
            Console.Title = "ATM Application";
            // sets the text color or foreground color to Gray
            Console.ForegroundColor = ConsoleColor.Gray;
            // set the welcome message 
            Console.WriteLine("\n---------------Welcome to My ATM App-------------\n");

            // prompt the user to insert atm card
            Console.WriteLine("Please insert your ATM card");
            Console.WriteLine("NOTE: Actual ATM machine will accept and validate a physical ATM card, read the card number an validate it");

            Utility.PressEnterToContinue();
            
        }


    }
}
