using System;
using System.Collections.Generic;

class Program
{
    static UserProfile user = new UserProfile("KaceyTafi");
    static Leaderboard leaderboard = new Leaderboard();
    const string FileName = "goals.txt";

    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("🌟 Welcome to Eternal Quest! 🌟\n");

        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("\n===== Main Menu =====");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. Record Goal Event");
            Console.WriteLine("3. Display Goals & Points");
            Console.WriteLine("4. Show Motivational Message");
            Console.WriteLine("5. Save Goals to File");
            Console.WriteLine("6. Load Goals from File");
            Console.WriteLine("7. Show Leaderboard");
            Console.WriteLine("8. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    RecordEvent();
                    break;
                case "3":
                    user.DisplayProfile();
                    break;
                case "4":
                    RewardSystem.DisplayMotivationalMessage();
                    break;
                case "5":
                    user.SaveToFile(FileName);
                    Console.WriteLine("✅ Profile saved to 'goals.txt'.");
                    break;
                case "6":
                    var loadedUser = UserProfile.LoadFromFile(FileName);
                    if (loadedUser != null)
                    {
                        user = loadedUser;
                        Console.WriteLine("✅ Profile loaded from 'goals.txt'.");
                    }
                    else
                    {
                        Console.WriteLine("❌ No saved profile found.");
                    }
                    break;
                case "7":
                    leaderboard.AddUser(user);
                    leaderboard.DisplayLeaderboard();
                    break;
                case "8":
                    Console.WriteLine("👋 Goodbye! Keep leveling up!");
                    exit = true;
                    break;
                default:
                    Console.WriteLine("❗ Invalid option. Try again.");
                    break;
            }
        }
    }

    static void CreateGoal()
    {
        Console.WriteLine("Choose Goal Type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Your choice: ");
        string type = Console.ReadLine();

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();

        Console.Write("Enter points: ");
        int points = int.Parse(Console.ReadLine());

        Goal goal = null;

        switch (type)
        {
            case "1":
                goal = new SimpleGoal(name, points);
                break;
            case "2":
                goal = new EternalGoal(name, points);
                break;
            case "3":
                Console.Write("Enter number of times to complete: ");
                int totalTimes = int.Parse(Console.ReadLine());

                Console.Write("Enter bonus points: ");
                int bonusPoints = int.Parse(Console.ReadLine());

                goal = new ChecklistGoal(name, points, totalTimes, bonusPoints);
                break;
            default:
                Console.WriteLine("❌ Invalid type selected.");
                return;
        }

        user.AddGoal(goal);
        Console.WriteLine("✅ Goal added successfully.");
    }

    static void RecordEvent()
    {
        if (user.Goals.Count == 0)
        {
            Console.WriteLine("⚠ No goals to record.");
            return;
        }

        Console.WriteLine("Choose a goal to record:");
        for (int i = 0; i < user.Goals.Count; i++)
        {
            Console.Write($"{i + 1}. ");
            user.Goals[i].DisplayGoal();
        }

        Console.Write("Enter goal number: ");
        if (int.TryParse(Console.ReadLine(), out int index))
        {
            index -= 1;

            if (index >= 0 && index < user.Goals.Count)
            {
                user.Goals[index].RecordEvent();
            }
            else
            {
                Console.WriteLine("❌ Invalid goal number.");
            }
        }
        else
        {
            Console.WriteLine("❌ Invalid input. Must be a number.");
        }
    }
}
