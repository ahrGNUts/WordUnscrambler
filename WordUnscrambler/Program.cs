using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordUnscrambler
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continueWordUnscramble = true;

            do
            {
                Console.WriteLine("Please enter option - F for file or M for manual");
                var option = Console.ReadLine() ?? string.Empty;

                switch (option.ToUpper())
                {
                    case "F":
                        Console.Write("Enter the scrambled words filename: ");
                        ExecuteScrambledWordsInFileScenario();
                        break;
                    case "M":
                        Console.Write("Enter scrambled words manually: ");
                        ExecuteScrambledWordsManualEntryScenario();
                        break;
                    default:
                        Console.Write("Option not recognized.");
                        break;
                }

                string continueUnscrambledWordDecision = string.Empty;
                do
                {
                    Console.Write("Do you want to continue? [y/n]: ");
                    continueUnscrambledWordDecision = (Console.ReadLine() ?? string.Empty);
                } while (
                    !continueUnscrambledWordDecision.Equals("Y", StringComparison.OrdinalIgnoreCase) && 
                    !continueUnscrambledWordDecision.Equals("N", StringComparison.OrdinalIgnoreCase));

                continueWordUnscramble = continueUnscrambledWordDecision.Equals("Y", StringComparison.OrdinalIgnoreCase);
            } while (continueWordUnscramble);
        }

        private static void ExecuteScrambledWordsManualEntryScenario()
        {

        }

        private static void ExecuteScrambledWordsInFileScenario()
        {
            
        }
    }
}
