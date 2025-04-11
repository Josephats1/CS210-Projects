

// Program.cs
class Program
{
    static void Main()
    {
        GoalManager manager = new();
        while (true)
        {
            Console.WriteLine("\nEternal Quest Program");
            Console.WriteLine($"Current Score: {manager.GetScore()}");
            Console.WriteLine("1. Create New Goal\n2. List Goals\n3. Record Event\n4. Save Goals\n5. Load Goals\n6. Quit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.WriteLine("Select Goal Type:\n1. Simple\n2. Eternal\n3. Checklist");
                    string type = Console.ReadLine();
                    Console.Write("Name: "); string name = Console.ReadLine();
                    Console.Write("Description: "); string desc = Console.ReadLine();
                    Console.Write("Points: "); int pts = int.Parse(Console.ReadLine());

                    if (type == "1") manager.AddGoal(new SimpleGoal(name, desc, pts));
                    else if (type == "2") manager.AddGoal(new EternalGoal(name, desc, pts));
                    else if (type == "3")
                    {
                        Console.Write("Target Count: "); int target = int.Parse(Console.ReadLine());
                        Console.Write("Bonus Points: "); int bonus = int.Parse(Console.ReadLine());
                        manager.AddGoal(new ChecklistGoal(name, desc, pts, target, bonus));
                    }
                    break;
                case "2":
                    manager.DisplayGoals();
                    break;
                case "3":
                    manager.DisplayGoals();
                    Console.Write("Enter goal number to record: ");
                    int idx = int.Parse(Console.ReadLine()) - 1;
                    manager.RecordEvent(idx);
                    break;
                case "4":
                    Console.Write("Filename to save: ");
                    manager.SaveGoals(Console.ReadLine());
                    break;
                case "5":
                    Console.Write("Filename to load: ");
                    manager.LoadGoals(Console.ReadLine());
                    break;
                case "6":
                    return;
            }
        }
    }
}