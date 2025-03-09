using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        bool playAgain = true;

        while (playAgain)
        {
            int magicNumber = random.Next(1, 101); // Generate random number between 1 and 100
            int guess = 0;
            int attempts = 0;
            int maxAttempts = 5; // Limit the number of attempts

            Console.WriteLine("Welcome to Guess My Number! You have 5 attempts.");
            
            while (guess != magicNumber && attempts < maxAttempts)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                attempts++;

                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine($"You guessed it! It took you {attempts} attempts.");
                    break;
                }
            }
            
            if (guess != magicNumber)
            {
                Console.WriteLine($"Sorry, you've run out of attempts! The number was {magicNumber}.");
            }

            Console.Write("Do you want to play again? (yes/no): ");
            string response = Console.ReadLine().ToLower();
            playAgain = (response == "yes");
        }

        Console.WriteLine("Thanks for playing! Goodbye!");
    }
}
