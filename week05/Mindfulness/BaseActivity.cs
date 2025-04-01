using System;
using System.Threading;

public abstract class BaseActivity
{
    private string _activityName;
    private string _description;
    private int _duration;

    public BaseActivity(string activityName, string description, int duration)
    {
        _activityName = activityName;
        _description = description;
        _duration = duration;
    }

    // Public methods to access private variables (encapsulation)
    public string ActivityName { get { return _activityName; } }
    public string Description { get { return _description; } }
    public int Duration { get { return _duration; } }

    // Method to start an activity
    public void StartActivity()
    {
        Console.WriteLine($"Starting {ActivityName}...");
        DisplayAnimation();
        Thread.Sleep(Duration * 1000); // Simulate activity duration
        EndActivity();
    }

    // Method to end an activity
    private void EndActivity()
    {
        Console.WriteLine($"Ending {ActivityName}...");
        DisplayAnimation();
    }

    // Method for pausing the program with animation
    public void DisplayAnimation()
    {
        for (int i = 0; i < 5; i++)
        {
            Console.Write(".");
            Thread.Sleep(500);
        }
        Console.WriteLine();
    }
}
