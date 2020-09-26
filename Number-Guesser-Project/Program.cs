using System;

// Namespace
namespace Number_Guesser_Project
{
    // Main Class
    class Program
    {
        // Entry Point Method
        static void Main(string[] args)
        {
            // Run function to get app info
            GetAppInfo();

            // Run function to greet user
            GreetUser();

            while (true)
            {
                // Init Random Correct Number from 1-10
                Random random = new Random();
                int correctNumber = random.Next(1, 10);

                // Init guess var
                int guess = 0;

                // Get user to guess number
                Console.WriteLine("Guess a number between 1 and 10");

                // While Loop to see if user input incorrect number
                while (guess != correctNumber)
                {
                    // Get User Input
                    string input = Console.ReadLine();

                    // Make Sure It's A Number
                    if (!int.TryParse(input, out guess))
                    {
                        // Print  Error Message
                        PrintColorMessage(ConsoleColor.DarkMagenta, "Please use an actual number");

                        // Keep game going
                        continue;
                    }

                    // Change User Input Into Integer And Put It Into Guess Variable
                    guess = Int32.Parse(input);

                    // See If Guess Is Not The Same As Correct Number
                    if (guess != correctNumber)
                    {
                        // Print  Error Message
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again!");
                    }
                }

                // Output Success Message

                // Print  Error Message
                PrintColorMessage(ConsoleColor.DarkCyan, "Congratulations, you win!");

                // Ask To Play Again
                Console.WriteLine("Play Again? [Y or N]");

                // Get Answer
                string answer = Console.ReadLine().ToUpper();

                // Response To Answer
                if(answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }
            }
        }
        // Get And Display App Info Function
        static void GetAppInfo()
        {
            // Set App Variables
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Mohamed Mohamud";

            // Change Text Color in Termianl
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            // App info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            // Reset Color in Terminal
            Console.ResetColor();
        }
        // Greet User Function
        static void GreetUser()
        {
            // Ask User Name
            Console.WriteLine("What is your name?");

            // Get User Input
            string inputName = Console.ReadLine();

            // Greet User
            Console.WriteLine("Hello {0}, let's play a game...", inputName);
        }
        // Print Color Message
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            // Change Text Color in Termianl
            Console.ForegroundColor = color;

            // Input Not A Number Message
            Console.WriteLine(message);

            // Reset Color in Terminal
            Console.ResetColor();
        }
    }
}
