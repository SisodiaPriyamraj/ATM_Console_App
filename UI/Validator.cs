using System;
using System.ComponentModel;

namespace ATMApp.UI
{
    public static class Validator
    {
        public static T Convert<T> (string prompt)
        {
            bool isValid = false;
            string userInput = string.Empty;

            while (!isValid)
            {
                userInput = Utility.GetUserInput(prompt);

                try
                {
                    var converter = TypeDescriptor.GetConverter(typeof(T));
                    if(converter != null)
                    {
                        return (T)converter.ConvertFromString(userInput);
                    }
                    else
                    {
                        return default (T);
                    }
                }
                catch(Exception ex)
                {
                    Utility.PrintMessage("Invalid Input. Try Again", false);  
                }
            }
            return default (T);
        }
    }
}
