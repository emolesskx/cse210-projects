using System;

public class Entry
{
    public string Prompt { get; set; }
    public string Response { get; set; }
    public string Date { get; set; }
    public string Category { get; set; }  // New property for category
    public string Emotion { get; set; }   // New property for emotion

    // Constructor
    public Entry(string prompt, string response, string category, string emotion)
    {
        Prompt = prompt;
        Response = response;
        Date = DateTime.Now.ToShortDateString();
        Category = category;
        Emotion = emotion;
    }

    // Display method for showing entry details
    public void Display()
    {
        Console.WriteLine($"Date: {Date}");
        Console.WriteLine($"Prompt: {Prompt}");
        Console.WriteLine($"Response: {Response}");
        Console.WriteLine($"Category: {Category}");
        Console.WriteLine($"Emotion: {Emotion}");
        Console.WriteLine();
    }
}
