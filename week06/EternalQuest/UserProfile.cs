using System;
using System.Collections.Generic;
using System.IO;

public class UserProfile
{
    public string UserName { get; private set; }
    public int TotalPoints { get; private set; }
    public List<Goal> Goals { get; private set; }

    public UserProfile(string userName)
    {
        UserName = userName;
        TotalPoints = 0;
        Goals = new List<Goal>();
    }

    public void AddGoal(Goal goal)
    {
        Goals.Add(goal);
    }

    public void AddPoints(int points)
    {
        TotalPoints += points;
    }

    public void DisplayProfile()
    {
        Console.WriteLine($"\nUser: {UserName}");
        Console.WriteLine($"Total Points: {TotalPoints}");
        Console.WriteLine("Goals:");
        for (int i = 0; i < Goals.Count; i++)
        {
            Console.Write($"{i + 1}. ");
            Goals[i].DisplayGoal();
        }
    }

    public void SaveToFile(string filePath)
    {
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            writer.WriteLine(UserName);
            writer.WriteLine(TotalPoints);
            foreach (Goal goal in Goals)
            {
                writer.WriteLine(goal.ToFileString()); // You must implement this in each subclass
            }
        }
    }

    public static UserProfile LoadFromFile(string filePath)
    {
        if (!File.Exists(filePath))
        {
            Console.WriteLine("File not found.");
            return null;
        }

        string[] lines = File.ReadAllLines(filePath);
        if (lines.Length < 2) return null;

        UserProfile user = new UserProfile(lines[0]);
        user.TotalPoints = int.Parse(lines[1]);

        for (int i = 2; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split('|');
            string type = parts[0];
            string name = parts[1];
            int points = int.Parse(parts[2]);

            switch (type)
            {
                case "SimpleGoal":
                    bool isComplete = bool.Parse(parts[3]);
                    user.Goals.Add(new SimpleGoal(name, points, isComplete));
                    break;

                case "EternalGoal":
                    user.Goals.Add(new EternalGoal(name, points));
                    break;

                case "ChecklistGoal":
                    int targetCount = int.Parse(parts[3]);
                    int currentCount = int.Parse(parts[4]);
                    int bonusPoints = int.Parse(parts[5]);
                    user.Goals.Add(new ChecklistGoal(name, points, targetCount, currentCount, bonusPoints));
                    break;

                default:
                    Console.WriteLine($"Unknown goal type: {type}");
                    break;
            }
        }

        return user;
    }
}
