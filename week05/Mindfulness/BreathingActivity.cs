using System;

public class BreathingActivity : BaseActivity
{
    public BreathingActivity(int duration) : base("Breathing", "A breathing activity to calm your mind", duration)
    {
    }

    // Method to perform breathing activity
    public void PerformBreathing()
    {
        Console.WriteLine("Breathe in... Hold... Breathe out...");
        Thread.Sleep(1000); // Simulate breathing actions
    }

    // Override start method to include breathing functionality
    public new void StartActivity()
    {
        base.StartActivity();
        PerformBreathing();
    }
}
