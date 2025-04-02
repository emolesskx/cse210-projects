using System;

class Program
{
    static void Main()
    {
        Scripture scripture = new Scripture(new Reference("Proverbs", 3, 5, 6), 
            "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight.");

        while (!scripture.IsFullyHidden())
        {
            Console.Clear();
            scripture.Display();
            Console.WriteLine("\nPress Enter to hide words or type 'reset' to restart or 'quit' to exit.");
            
            string input = Console.ReadLine().ToLower();
            if (input == "quit")
                break;
            else if (input == "reset")
            {
                scripture.Reset();
                continue;
            }

            scripture.HideRandomWords(3); // Hide 3 words at a time
        }

        Console.Clear();
        scripture.Display();
        Console.WriteLine("\nAll words are hidden. Program ended.");
    }
}
