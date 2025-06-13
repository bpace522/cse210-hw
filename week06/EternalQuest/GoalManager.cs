using System;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        string choice = "";
        while (choice != "6")
        {
            Console.WriteLine($"\nYou have {_score} points.");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    ListGoalDetails();
                    break;
                case "3":
                    SaveGoals();
                    break;
                case "4":
                    LoadGoals();
                    break;
                case "5":
                    RecordEvent();
                    break;
            }
        }
        Console.WriteLine("Goodbye");
    }

    public void DisplayPlayInfo()
    {

    }

    public void ListGoalNames()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("Your goals:");
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string choice = Console.ReadLine();

        Console.Write("Enter the name of your goal: ");
        string name = Console.ReadLine();
        Console.Write("Enter a short description: ");
        string description = Console.ReadLine();
        Console.Write("Enter the points that will be awarded: ");
        int points = int.Parse(Console.ReadLine());

        if (choice == "1")
        {
            _goals.Add(new SimpleGoal(name, description, points));
        }
        else if (choice == "2")
        {
            _goals.Add(new EternalGoal(name, description, points));
        }
        else if (choice == "3")
        {
            Console.Write("Enter number of times to complete the goal: ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("What would you like the bonus (received on completion) to be? ");
            int bonus = int.Parse(Console.ReadLine());
            _goals.Add(new ChecklistGoal(name, description, points, 0, target, bonus));
        }
    }

    public void RecordEvent()
    {
        Console.WriteLine("Which goal did you accomplish?");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }

        Console.Write("Enter the number of the goal: ");
        if (int.TryParse(Console.ReadLine(), out int index))
        {
            index -= 1;

            if (index < 0 || index >= _goals.Count)
            {
                Console.WriteLine("Invalid selection.");
                return;
            }

            int earnedPoints = _goals[index].RecordEvent();
            _score += earnedPoints;

            Console.WriteLine($"You earned {earnedPoints} points!");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number.");
        }
    }



    public void SaveGoals()
    {
        Console.Write("Enter filename to save to: ");
        string fileName = Console.ReadLine();
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            writer.WriteLine($"Score:{_score}");
            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals()
    {
        Console.Write("Enter the filename to load: ");
        string filename = Console.ReadLine();

        if (File.Exists(filename))
        {
            string[] lines = File.ReadAllLines(filename);

            string scoreLine = lines[0];
            if (scoreLine.StartsWith("Score:"))
            {
                _score = int.Parse(scoreLine.Substring(6));
            }

            _goals.Clear();

            for (int i = 1; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split("|");
                string type = parts[0];
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);

                if (type == "SimpleGoal")
                {
                    bool isComplete = bool.Parse(parts[4]);
                    SimpleGoal goal = new SimpleGoal(name, description, points);
                    goal.SetComplete(isComplete);
                    _goals.Add(goal);
                }
                else if (type == "EternalGoal")
                {
                    EternalGoal goal = new EternalGoal(name, description, points);
                    _goals.Add(goal);
                }
                else if (type == "ChecklistGoal")
                {
                    int amountCompleted = int.Parse(parts[4]);
                    int target = int.Parse(parts[5]);
                    int bonus = int.Parse(parts[6]);

                    ChecklistGoal goal = new ChecklistGoal(name, description, points, amountCompleted, target, bonus);
                    _goals.Add(goal);
                }
            }

            Console.WriteLine("Goals successfully loaded.");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}