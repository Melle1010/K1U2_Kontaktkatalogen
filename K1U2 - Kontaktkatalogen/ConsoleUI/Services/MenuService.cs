using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K1U2___Kontaktkatalogen.ConsoleUI.Services
{
    internal class MenuService
    {
        /// <summary>
        /// Prompts the user for input and ensures it is a valid integer
        /// within the optional min and max bounds.
        /// </summary>
        /// <param name="min">The inclusive minimum allowed value. If null, no minimum is enforced.</param>
        /// <param name="max">The inclusive maximum allowed value. If null, no maximum is enforced.</param>
        /// <returns>The valid input string that represents a number in the specified range.</returns>
        public static string HandleInput(int? min = null, int? max = null)
        {
            string input;
            int number; // STORES PARSED VALUE
            while (true)
            {
                string prompt = "Please enter a whole number";
                if (min.HasValue && max.HasValue)
                {
                    prompt += $" (between {min.Value} and {max.Value})";
                }
                else if (min.HasValue)
                {
                    prompt += $" ({min.Value} or higher)";
                }
                else if (max.HasValue)
                {
                    prompt += $" ({max.Value} or lower)";
                }
                prompt += ": ";
                Console.Write(prompt);

                input = Console.ReadLine();

                if (!int.TryParse(input, out number))
                {
                    Console.WriteLine("\nERROR: That is not a valid whole number. Please try again.\n");
                    continue;
                }
                if (min.HasValue && number < min.Value)
                {
                    Console.WriteLine($"\nERROR: The number must be at least {min.Value}. Please try again.\n");
                    continue;
                }
                if (max.HasValue && number > max.Value)
                {
                    Console.WriteLine($"\nERROR: The number must be no more than {max.Value}. Please try again.\n");
                    continue;
                }
                break;
            }

            return input;
        }
        
    }
}
