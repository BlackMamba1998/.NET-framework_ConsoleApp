using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Namespace
namespace PogodiBroj
{
    class Program
    {
        // Entry Point Method
        static void Main(string[] args)
        {
            getAppInfo();

            //Ask users name
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("What is your name");
            Console.ResetColor();

            // Get user input
            string input = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Hello {0}, let's play a game...", input);

        Igra:

            // Init how many tries
            int numTry = 1;

            // Init correct number
            System.Random random = new System.Random();
            int correctNumber = random.Next(1,11);

            // Init guess var
            int guess = 0;

            // Ask user for number
            Console.WriteLine("Guess a number between 1 and 10");
            Console.ResetColor();

            while (guess != correctNumber)
            {
                //ulaz
                input = Console.ReadLine();

                //provjera unosa
                bool isParsable = Int32.TryParse(input, out guess);

                if (!isParsable) {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wrong input! You are guessing a number.");
                    Console.ResetColor();
                }
                //usporedba
                if (guess!= correctNumber)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Incorrect! Try again!");
                    Console.ResetColor();
                    numTry++;
                }

                else {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Correct! You gueesed it after {0} {1}.", numTry, numTry > 1 ? "tries" : "try");
                    Console.ResetColor();

                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Do you want to play again? (y/n)");
                    Console.ResetColor();

                    input = Console.ReadLine();

                    if (input.ToLower() == "y")
                    {
                        goto Igra;
                    }
                    else
                    {
                        return;
                    }
                }
            }
            }


        static void getAppInfo()
        {
            //*Set app vars
            string appName = "POGODI BROJ!";
            string appVersion = "1.0.0";
            string appAuthor = "Frane Žada";

            // Change text color//

            Console.ForegroundColor = ConsoleColor.DarkYellow;

            // Write out app info
            Console.WriteLine("{0} : Version {1} by {2}\n", appName, appVersion, appAuthor);

            //Reset color
            Console.ResetColor();
        }

    }
}
