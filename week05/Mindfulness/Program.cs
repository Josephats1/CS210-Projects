using System;

class Program
{
    static void Main(string[] args)
    {
        // Create instances of activities
        BreathingActivity breathing = new BreathingActivity(5); // Duration in seconds
        ListingActivity listing = new ListingActivity(5);
        ReflectingActivity reflecting = new ReflectingActivity(5);

        // Start activities
        breathing.StartActivity();
        listing.StartActivity();
        reflecting.StartActivity();
    }
}d
