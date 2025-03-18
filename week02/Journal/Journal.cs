using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> _entries;
    private string[] _prompts = {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };

    public Journal()
    {
        _entries = new List<Entry>();
    }

    // Add a new entry to the journal
    public void AddEntry()
    {
        Random rand = new Random();
        string prompt = _prompts[rand.Next(_prompts.Length)];

        Console.WriteLine($"Prompt: {prompt}");
        Console.Write("Your response: ");
        string response = Console.ReadLine();

        Console.Write("Category (e.g., Personal, Work): ");
        string category = Console.ReadLine();

        Console.Write("Emotion (e.g., Happy, Sad): ");
        string emotion = Console.ReadLine();

        Entry newEntry = new Entry(prompt, response, category, emotion);
        _entries.Add(newEntry);

        Console.WriteLine("Entry added successfully!\n");
    }

    // Display all entries
    public void DisplayJournal()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries found.\n");
        }
        else
        {
            foreach (var entry in _entries)
            {
                entry.Display();
            }
        }
    }

    // Save journal to CSV file
    public void SaveToCSV(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in _entries)
            {
                writer.WriteLine($"\"{entry.Date}\",\"{entry.Prompt}\",\"{entry.Response}\",\"{entry.Category}\",\"{entry.Emotion}\"");
            }
        }
        Console.WriteLine($"Journal saved to {filename}.\n");
    }

    // Load journal from CSV file
    public void LoadFromCSV(string filename)
    {
        _entries.Clear();
        string[] lines = File.ReadAllLines(filename);

        foreach (var line in lines)
        {
            string[] parts = line.Split(',');
            string date = parts[0].Trim('"');
            string prompt = parts[1].Trim('"');
            string response = parts[2].Trim('"');
            string category = parts[3].Trim('"');
            string emotion = parts[4].Trim('"');

            Entry entry = new Entry(prompt, response, category, emotion) { Date = date };
            _entries.Add(entry);
        }

        Console.WriteLine("Journal loaded from file.\n");
    }
}
