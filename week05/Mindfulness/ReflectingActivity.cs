using System;

public class ReflectingActivity : BaseActivity
{
    public ReflectingActivity(int duration) : base("Reflecting", "Reflect on your thoughts and feelings", duration)
    {
    }

    // Method to perform reflecting activity
    public void PerformReflection()
    {
        string[] prompts = { "What are you grateful for?", "What did you learn today?", "What are your goals?" };
        Random rand = new Random();
        int index = rand.Next(prompts.Length);

        Console.WriteLine($"Reflection prompt: {prompts[index]}");
        Console.WriteLine("Take a moment to reflect.");
        Thread.Sleep(2000); // Simulate reflection time
    }

    // Override start method to include reflecting functionality
    public new void StartActivity()
    {
        base.StartActivity();
        PerformReflection();
    }
}
