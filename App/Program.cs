using ATMApp.UI;
using System;

namespace ATMApp
{
    class Program
    {
        static void Main(string[] args)
        {
            AppScreen.Welcome();
            long cardNumber = Validator.Convert<long>("enter your card number");
            Console.WriteLine($"Your card number is: {cardNumber}");

            Utility.PressEnterToContinue();
        }
    }
}
