// BaseActivity.cs
using System;
using System.Threading;

abstract class BaseActivity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public void Start()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity.");
        Console.WriteLine($"{_description}\n");
        Console.Write("Enter the duration of the activity in seconds: ");
        _duration = int.Parse(Console.ReadLine());

        Console.WriteLine("\nPrepare to begin...");
        ShowSpinner(3);
        PerformActivity();
        End();
    }

    protected void End()
    {
        Console.WriteLine("\nGood job!");
        ShowSpinner(3);
        Console.WriteLine($"You have completed the {_name} Activity for {_duration} seconds.");
        ShowSpinner(3);
    }

    protected void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds * 4; i++)
        {
            Console.Write("|/-\\"[i % 4]);
            Thread.Sleep(250);
            Console.Write("\b");
        }
    }

    protected void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i} ");
            Thread.Sleep(1000);
            Console.Write("\b\b");
        }
        Console.WriteLine();
    }

    public abstract void PerformActivity();
}

// BreathingActivity.cs
using System;
using System.Threading;

class BreathingActivity : BaseActivity
{
    public BreathingActivity()
    {
        _name = "Breathing";
        _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public override void PerformActivity()
    {
        int cycleDuration = 6; // 3s in, 3s out
        int cycles = _duration / cycleDuration;
        for (int i = 0; i < cycles; i++)
        {
            Console.Write("Breathe in... ");
            Countdown(3);
            Console.Write("Breathe out... ");
            Countdown(3);
        }
    }
}