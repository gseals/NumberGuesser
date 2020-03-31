using System;


// Namespace
namespace NumberGuesser
{
    // Main Class
    class Program
    {
        // Entry Point Method
        // static and void:
        // void is the return type and means there is not going to be one, it does not return anything. you can return strings, ints, etc. void means nothing is returned
        // when we create a class, we can instantiate objects from that and we can create multiple instances of that object using that class.
        // when we use static, static means we are referring to the function itself
        static void Main(string[] args)
        {
            //string name = "Brad Traversy";
            //int age = 35;
            //Console.WriteLine("{0} is {1}",name,age);
            // START HERE //

            GetAppInfo(); // run GetAppInfo function to get app info

            GreetUser(); // ask for user's name and greet

            while (true)
            {
                // Init correct number
                //int correctNumber = 7;

                // Create a new random object
                Random random = new Random();

                // Init guess var
                int correctNumber = random.Next(1, 10);

                // Init guess var
                int guess = 0;

                // ask user for number
                Console.WriteLine("Guess a number between 1 and 10");

                // while guess is not correct
                while (guess != correctNumber)
                {
                    // get user's input
                    string input = Console.ReadLine();

                    // Make sure it's a number
                    if (!int.TryParse(input, out guess))
                    {
 
                        //Print error message
                        PrintColorMessage(ConsoleColor.Red, "Please use an actual number");

                        // Keep going
                        continue;
                    }

                    // cast to int and put in guess
                    guess = Int32.Parse(input);

                    // Match guess to correct number
                    if (guess != correctNumber)
                    {
                        // Print error message
                        PrintColorMessage(ConsoleColor.Red, "Wrong number. Please try again.");
                    }

                }

                // Output success message
                PrintColorMessage(ConsoleColor.Yellow, "You are correct!");

                // Ask to play again
                Console.WriteLine("Play again? [Y or N]");

                // get answer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
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

        // get and display app info
        static void GetAppInfo()
        {
            // set app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Gabe Seals";

            // Change text color
            Console.ForegroundColor = ConsoleColor.Green;

            // Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            // reset text color
            Console.ResetColor();
        }

        // ask user's name and greet
        static void GreetUser()
        {
            // Ask user's name
            Console.WriteLine("What is your name?");

            // Get user input
            string inputName = Console.ReadLine();

            // Greet user and prompt game
            Console.WriteLine("Hello {0}, let's play a game...", inputName);
        }

        // Print color message
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            // Change text color
            Console.ForegroundColor = color;

            // Write out app info
            Console.WriteLine(message);

            // reset text color
            Console.ResetColor();
        }
    }
}
