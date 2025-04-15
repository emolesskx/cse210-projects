public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, int points, bool isComplete = false) : base(name, points)
    {
        _isComplete = isComplete;
    }

    public override void DisplayGoal()
    {
        string status = _isComplete ? "[X]" : "[ ]";
        Console.WriteLine($"{status} {_name} ({_points} pts)");
    }

    public override void RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            Console.WriteLine($"Goal completed! You earned {_points} points.");
        }
        else
        {
            Console.WriteLine("This goal is already complete.");
        }
    }

    public override string ToFileString()
    {
        return $"SimpleGoal|{_name}|{_points}|{_isComplete}";
    }
}
