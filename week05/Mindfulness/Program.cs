// BONUS: Added a new activity called "GratitudeActivity" which allows the user to type things they're grateful for
// to increase positivity and emotional well-being.

using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            BaseActivity activity = null;
            switch (choice)
            {
                case "1": activity = new BreathingActivity(); break;
                case "2": activity = new ReflectionActivity(); break;
                case "3": activity = new ListingActivity(); break;
                case "4": return;
                default: Console.WriteLine("Invalid choice. Try again."); Thread.Sleep(2000); continue;
            }

            activity.Start();
            Console.WriteLine("\nPress Enter to return to the menu.");
            Console.ReadLine();
        }
    }
}