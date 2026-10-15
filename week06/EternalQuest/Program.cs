
using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        string choice = "";

        // Extra feature: Users earn levels as their score increases.
        // Every 500 points increases their level.

        while (choice != "7")
        {
            Console.WriteLine();
            Console.WriteLine("=== ETERNAL QUEST ===");
            Console.WriteLine($"Score: {manager.GetScore()}");
            Console.WriteLine($"Level: {manager.GetLevel()}");
            Console.WriteLine();
            Console.WriteLine("1. Create Goal");
            Console.WriteLine("2. Show Goals");
            Console.WriteLine("3. Record Goal Event");
            Console.WriteLine("4. Show Score");
            Console.WriteLine("5. Save Goals");
            Console.WriteLine("6. Load Goals");
            Console.WriteLine("7. Quit");
            Console.Write("Choose an option: ");

            choice = Console.ReadLine() ?? "";

            switch (choice)
            {
                case "1":
                    CreateGoal(manager);
                    break;

                case "2":
                    manager.ShowGoals();
                    break;

                case "3":
                    RecordGoal(manager);
                    break;

                case "4":
                    Console.WriteLine($"Your score is {manager.GetScore()} points.");
                    Console.WriteLine($"Your level is {manager.GetLevel()}.");
                    break;

                case "5":
                    manager.SaveGoals();
                    break;

                case "6":
                    manager.LoadGoals();
                    break;

                case "7":
                    Console.WriteLine("Keep working on your Eternal Quest!");
                    break;

                default:
                    Console.WriteLine("Please choose a number from 1 to 7.");
                    break;
            }
        }
    }

    static void CreateGoal(GoalManager manager)
    {
        Console.WriteLine();
        Console.WriteLine("Choose a goal type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Choose: ");

        string type = Console.ReadLine() ?? "";

        if (type != "1" && type != "2" && type != "3")
        {
            Console.WriteLine("Invalid goal type.");
            return;
        }

        Console.Write("Goal name: ");
        string name = Console.ReadLine() ?? "";

        Console.Write("Description: ");
        string description = Console.ReadLine() ?? "";

        int points = AskNumber("Points: ", 1);

        if (type == "1")
        {
            manager.AddGoal(new SimpleGoal(name, description, points));
        }
        else if (type == "2")
        {
            manager.AddGoal(new EternalGoal(name, description, points));
        }
        else
        {
            int target = AskNumber("How many times must you complete it? ", 1);
            int bonus = AskNumber("Bonus points: ", 0);

            manager.AddGoal(
                new ChecklistGoal(name, description, points, target, bonus));
        }

        Console.WriteLine("Goal created!");
    }

    static void RecordGoal(GoalManager manager)
    {
        if (manager.GetGoalCount() == 0)
        {
            Console.WriteLine("Create a goal first.");
            return;
        }

        manager.ShowGoals();

        int number = AskNumber("Enter the goal number to record: ", 1);

        if (number > manager.GetGoalCount())
        {
            Console.WriteLine("That goal number does not exist.");
            return;
        }

        int earned = manager.RecordEvent(number - 1);

        Console.WriteLine($"You earned {earned} points!");
        Console.WriteLine($"Total score: {manager.GetScore()}");
    }

    static int AskNumber(string message, int minimum)
    {
        int number;

        while (true)
        {
            Console.Write(message);
            string input = Console.ReadLine() ?? "";

            if (int.TryParse(input, out number) && number >= minimum)
            {
                return number;
            }

            Console.WriteLine($"Enter a whole number of at least {minimum}.");
        }
    }
}
