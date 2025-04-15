using System;
using System.Linq;
using System.Collections.Generic;

public class Leaderboard
{
    private List<UserProfile> users;

    public Leaderboard()
    {
        users = new List<UserProfile>();
    }

    public void AddUser(UserProfile user)
    {
        users.Add(user);
    }

    public void DisplayLeaderboard()
    {
        Console.WriteLine("Leaderboard:");
        var sortedUsers = users.OrderByDescending(u => u.TotalPoints).Take(10);
        foreach (var user in sortedUsers)
        {
            Console.WriteLine($"{user.UserName}: {user.TotalPoints} points");
        }
    }
}
