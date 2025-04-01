using System;
using System.Collections.Generic;

public class ListingActivity : BaseActivity
{
    public ListingActivity(int duration) : base("Listing", "List your thoughts", duration)
    {
    }

    // Method to perform listing activity
    public void PerformListing()
    {
        List<string> items = new List<string>();
        Console.WriteLine("Start listing items. Type 'done' when finished.");

        while (true)
        {
            string input = Console.ReadLine();
            if (input.ToLower() == "done") break;
            items.Add(input);
        }

        Console.WriteLine($"You listed {items.Count} items.");
    }

    // Override start method to include listing functionality
    public new void StartActivity()
    {
        base.StartActivity();
        PerformListing();
    }
}
