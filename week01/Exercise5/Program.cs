using System;

class Program
{
    // Function to display the welcome message
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    // Function to prompt the user for their name
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    // Function to prompt the user for their favorite number
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        return int.Parse(Console.ReadLine());
    }

    // Function to square a number
    static int SquareNumber(int number)
    {
        return number * number;
    }

    // Function to display the result
    static void DisplayResult(string name, int squaredNumber)
    {
        Console.WriteLine($"{name}, the square of your number is {squaredNumber}");
    }

    static void Main(string[] args)
    {
        // Call DisplayWelcome function
        DisplayWelcome();

        // Call PromptUserName and store the result in a variable
        string userName = PromptUserName();

        // Call PromptUserNumber and store the result in a variable
        int userNumber = PromptUserNumber();

        // Call SquareNumber function with the user number
        int squaredNumber = SquareNumber(userNumber);

        // Call DisplayResult to display the final message
        DisplayResult(userName, squaredNumber);
    }
}
