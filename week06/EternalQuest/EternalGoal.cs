public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points) {}

    public override void RecordEvent()
    {
        Console.WriteLine($"Good job! You earned {GetPoints()} points.");
    }

    public override string GetStatus() =>
        $"[ ] {GetName()} ({GetDescription()})";

    public override string GetStringRepresentation() =>
        $"EternalGoal|{GetName()}|{GetDescription()}|{GetPoints()}";
}
