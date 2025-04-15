public class EternalGoal : Goal
{
    public EternalGoal(string name, int points) : base(name, points) { }

    public override void DisplayGoal()
    {
        Console.WriteLine($"[∞] {_name} ({_points} pts per time)");
    }

    public override void RecordEvent()
    {
        Console.WriteLine($"You earned {_points} points.");
    }

    public override string ToFileString()
    {
        return $"EternalGoal|{_name}|{_points}";
    }
}
