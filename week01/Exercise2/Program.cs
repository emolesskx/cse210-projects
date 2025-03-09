using System;

class Program
{
    static void Main()
    {
        // Ask the user for their grade percentage
        Console.Write("Enter your grade percentage: ");
        int percentage = int.Parse(Console.ReadLine());

        string letter = "";
        string sign = "";

        // Determine letter grade
        if (percentage >= 90)
        {
            letter = "A";
        }
        else if (percentage >= 80)
        {
            letter = "B";
        }
        else if (percentage >= 70)
        {
            letter = "C";
        }
        else if (percentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Determine sign (+ or -)
        int lastDigit = percentage % 10;
        if (letter != "A" && letter != "F") // A+ and F+/F- do not exist
        {
            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
        }
        else if (letter == "A" && percentage < 93) // A- case
        {
            sign = "-";
        }

        // Display the final letter grade with sign
        Console.WriteLine($"Your grade is: {letter}{sign}");

        // Determine if the user passed
        if (percentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed the class.");
        }
        else
        {
            Console.WriteLine("Keep trying! You'll do better next time.");
        }
    }
}
