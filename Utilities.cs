using System;
using System.Linq;

namespace Utilities
{
    public class Utils
    {
        public static int GetInt(int minRange = Int32.MinValue, int maxRange = Int32.MaxValue)
        {
            while (true)
            {
                string x = Console.ReadLine();
                if (int.TryParse(x, out int input))
                    if (input < minRange || input > maxRange)
                        Console.WriteLine($"Your number needs to be between {minRange} and {maxRange}.");
                    else
                        return input;
                else
                    Console.WriteLine("That's not a valid input, try again!");
            }
        }
        
        public static string GetString(int minRange = Int32.MinValue, int maxRange = Int32.MaxValue, bool lettersOnly = false)
        {
            while (true)
            {
                string x = Console.ReadLine();
                if (x.Length < minRange || x.Length > maxRange)
                    Console.WriteLine($"Your string needs to be between {minRange} and {maxRange}.");
                else
                if (lettersOnly)
                    if (x.All(char.IsDigit))
                        Console.WriteLine("No numbers in the string, try again!");
                    else return x;
                return x;
            }
        }
    }
}