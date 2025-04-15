public class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonusPoints;

    public ChecklistGoal(string name, int points, int targetCount, int currentCount = 0, int bonusPoints = 0)
        : base(name, points)
    {
        _targetCount = targetCount;
        _currentCount = currentCount;
        _bonusPoints = bonusPoints;
    }

    public override void DisplayGoal()
    {
        Console.WriteLine($"[✔] {_name} - {_currentCount}/{_targetCount} ({_points} pts each, {_bonusPoints} bonus)");
    }

    public override void RecordEvent()
    {
        _currentCount++;
        Console.WriteLine($"You earned {_points} points.");
        if (_currentCount == _targetCount)
        {
            Console.WriteLine($"Checklist complete! Bonus {_bonusPoints} points earned.");
        }
    }

    public override string ToFileString()
    {
        return $"ChecklistGoal|{_name}|{_points}|{_targetCount}|{_currentCount}|{_bonusPoints}";
    }
}
