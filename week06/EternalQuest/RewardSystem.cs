public class RewardSystem
{
    public static void AwardBadge(UserProfile profile)
    {
        if (profile.Goals.Count >= 5)
        {
            Console.WriteLine($"Congratulations {profile.UserName}! You've earned the 'Goal Master' badge!");
        }
    }

    public static void DisplayMotivationalMessage()
    {
        string[] messages = {
            "Great job, keep going!",
            "You're doing amazing!",
            "Keep up the good work!",
            "Every step counts, you're on the right track!"
        };
        Random rand = new Random();
        int index = rand.Next(messages.Length);
        Console.WriteLine(messages[index]);
    }
}
