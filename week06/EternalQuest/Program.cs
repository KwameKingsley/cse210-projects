using System;

class Program
{
    static void Main()
    {
        GoalManager manager = new GoalManager();
        DataHandler dataHandler = new DataHandler();
        dataHandler.Load(manager); // Load saved goals and progress

        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== Goal Tracking System ===");
            Console.WriteLine($"Score: {manager.Score} | Level: {manager.Level} | Streak: {manager.Streak} days");
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Create a New Goal");
            Console.WriteLine("2. View Goals");
            Console.WriteLine("3. Record an Event");
            Console.WriteLine("4. Save Progress");
            Console.WriteLine("5. Load Progress");
            Console.WriteLine("6. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    CreateGoal(manager);
                    break;
                case "2":
                    manager.DisplayGoals();
                    Console.WriteLine("\nPress Enter to return to menu...");
                    Console.ReadLine();
                    break;
                case "3":
                    RecordEvent(manager);
                    break;
                case "4":
                    dataHandler.Save(manager);
                    Console.WriteLine("Progress saved successfully!");
                    Console.ReadLine();
                    break;
                case "5":
                    dataHandler.Load(manager);
                    Console.WriteLine("Progress loaded successfully!");
                    Console.ReadLine();
                    break;
                case "6":
                    return;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    Console.ReadLine();
                    break;
            }
        }
    }

    static void CreateGoal(GoalManager manager)
    {
        Console.Clear();
        Console.WriteLine("Choose Goal Type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.WriteLine("4. Negative Goal");
        Console.Write("Enter your choice: ");
        
        string choice = Console.ReadLine();
        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();
        Console.Write("Enter point value: ");
        int points = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case "1":
                manager.AddGoal(new SimpleGoal(name, description, points));
                break;
            case "2":
                manager.AddGoal(new EternalGoal(name, description, points));
                break;
            case "3":
                Console.Write("Enter target count: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Enter completion bonus: ");
                int bonus = int.Parse(Console.ReadLine());
                manager.AddGoal(new ChecklistGoal(name, description, points, target, bonus));
                break;
            case "4":
                manager.AddGoal(new NegativeGoal(name, description, points));
                break;
            default:
                Console.WriteLine("Invalid choice!");
                break;
        }

        Console.WriteLine("Goal added successfully!");
        Console.ReadLine();
    }

    static void RecordEvent(GoalManager manager)
    {
        Console.Clear();
        manager.DisplayGoals();
        Console.Write("Enter the number of the goal to record: ");
        
        if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= manager.GetGoals().Count)
        {
            manager.RecordEvent(index - 1);
            Console.WriteLine("Event recorded successfully!");
        }
        else
        {
            Console.WriteLine("Invalid selection.");
        }

        Console.ReadLine();
    }
}

// Added creativity like Negative Goals where you loose points for doing those
// Also added leveling up for earning bonuses