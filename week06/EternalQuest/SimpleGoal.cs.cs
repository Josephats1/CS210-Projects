public class SimpleGoal : Goal
{
    private bool _isComplete = false;

    public SimpleGoal(string name, string description, int points)
        : base(name, description, points) {}

    public override void RecordEvent()
    {
        _isComplete = true;
        Console.WriteLine($"Goal completed! You earned {GetPoints()} points.");
    }

    public override bool IsComplete() => _isComplete;

    public override string GetStatus() =>
        $"[{"X",1}] {GetName()} ({GetDescription()})";

    public override string GetStringRepresentation() =>
        $"SimpleGoal|{GetName()}|{GetDescription()}|{GetPoints()}|{_isComplete}";
}
