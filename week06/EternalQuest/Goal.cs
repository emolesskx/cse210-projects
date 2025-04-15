public abstract class Goal
{
    protected string _name;
    protected int _points;

    public Goal(string name, int points)
    {
        _name = name;
        _points = points;
    }

    public abstract void DisplayGoal();
    public abstract void RecordEvent();
    public abstract string ToFileString(); // <== This is the method to implement
}
