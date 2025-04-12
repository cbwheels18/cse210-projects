

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    private int _level;
    private int _experiencePoints;

    private string _userInput;
    

    public GoalManager()
    {
        _score = 0;
        _level = 1;
        _experiencePoints = 0;
    }

    public string GetUserInput()
    {
        return _userInput;
    }

    public int GetScore()
    {
        return _score;
    }

    public string UserSelection()
    {
        Console.WriteLine("\nMenu Options:");
        Console.WriteLine("    1. Create New Goal");
        Console.WriteLine("    2. List Goals");
        Console.WriteLine("    3. Save Goals");
        Console.WriteLine("    4. Load Goals");
        Console.WriteLine("    5. Record Event");
        Console.WriteLine("    6. Quit");
        Console.Write("Please select an option from the menu: ");

        _userInput = Console.ReadLine();
        return _userInput;
    }

    public string MenuEternalQuest()
    {
        while (_userInput != "6")
        {
            DisplayPlayerInfo();
            UserSelection();

            if (_userInput == "1")
            {
                CreateGoal();
                Console.WriteLine("Create New Goal");
            }
            else if (_userInput == "2")
            {
                ListGoalNames();
                ListGoalDetails();
            }
            else if (_userInput == "3")
            {
                SaveGoals();
                Console.WriteLine("Save Goals");
            }
            else if (_userInput == "4")
            {
                LoadGoals();
                Console.WriteLine("Load Goals");
            }
            else if (_userInput == "5")
            {
                RecordEvent();
                DisplayPlayerInfo();
                Console.WriteLine("Record Events");
            }
            else if (_userInput == "6")
            {
                Console.WriteLine("Exiting the program. Thanks for participating!");
            }
            else
            {
                Console.WriteLine("Invalid selection. Please try again.");
            }
        }

    return "Exited the menu.";
    }


    public void Start()
    {

    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Player Score: {_score} | Level: {_level} | XP: {_experiencePoints}/10");
    }

    public void ListGoalNames()
    {
        Console.WriteLine("Goals List:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDisplayString()}");
        }
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("Goals Details:");
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetDisplayString());
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("Select the type of goal to create:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Enter the Option number: ");

        string goalType = Console.ReadLine();

        if (goalType == "1")
        {
            Console.Write("Enter the short name: ");
            string shortName = Console.ReadLine();
            Console.Write("Enter the description: ");
            string description = Console.ReadLine();
            Console.Write("Enter the points: ");
            int points = int.Parse(Console.ReadLine());

            SimpleGoal simpleGoal = new SimpleGoal(shortName, description, points);
            _goals.Add(simpleGoal);
        }
        else if (goalType == "2")
        {
            Console.Write("Enter the short name: ");
            string shortName = Console.ReadLine();
            Console.Write("Enter the description: ");
            string description = Console.ReadLine();
            Console.Write("Enter the points: ");
            int points = int.Parse(Console.ReadLine());

            EternalGoal eternalGoal = new EternalGoal(shortName, description, points);
            _goals.Add(eternalGoal);
        }
        else if (goalType == "3")
        {
            Console.Write("Enter the short name: ");
            string shortName = Console.ReadLine();
            Console.Write("Enter the description: ");
            string description = Console.ReadLine();
            Console.Write("Enter the points: ");
            int points = int.Parse(Console.ReadLine());
            Console.Write("Enter the target: ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("Enter the bonus: ");
            int bonus = int.Parse(Console.ReadLine());

            ChecklistGoal checklistGoal = new ChecklistGoal(shortName, description, points, target, bonus);
            _goals.Add(checklistGoal);
        }
        else
        {
            Console.WriteLine("Invalid goal type selected.");
            return;
        }
        Console.WriteLine("Goal created successfully!");

    }

    public void RecordEvent()
    {
        Console.WriteLine("Select a goal to record an event for:");
        ListGoalNames();
        Console.Write("Please select a goal number: ");

        if (int.TryParse(Console.ReadLine(), out int goalIndex))
        {
            goalIndex -= 1;

            if (goalIndex >= 0 && goalIndex < _goals.Count)
            {
                Goal selectedGoal = _goals[goalIndex];
                int pointsEarned = selectedGoal.RecordEvent();
                _score += pointsEarned;

                int xpEarned = 0;

                if (selectedGoal is SimpleGoal)
                {
                    xpEarned = 1;
                }
                else if (selectedGoal is EternalGoal)
                {
                    xpEarned = 2;
                }
                else if (selectedGoal is ChecklistGoal checklist)
                {
                    xpEarned = 2;
                    if (checklist.IsComplete())
                    {
                        xpEarned += 3;
                    }
                }

                _experiencePoints += xpEarned;

                while (_experiencePoints >= 10)
                {
                    _experiencePoints -= 10;
                    _level++;
                    Console.WriteLine($"🎉 Congratulations! You've reached Level {_level}!");
                }

                Console.WriteLine($"Event recorded! +{xpEarned} XP | Total Score: {_score} | Level: {_level} | XP: {_experiencePoints}/10");
            }
            else
            {
                Console.WriteLine("Invalid goal index selected.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }



    public void SaveGoals()
    {
        Console.WriteLine("Type in the name of the file you want to save it to: ");
        string filename = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine($"Score|{_score}");
            writer.WriteLine($"Level|{_level}");
            writer.WriteLine($"XP|{_experiencePoints}");

            foreach (var goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }

        Console.WriteLine("Goals, score, level, and XP saved successfully!");
    }


    public void LoadGoals()
    {
        Console.WriteLine("Type in the name of the file you want to load from: ");
        string filename = Console.ReadLine();

        _goals.Clear();

        using (StreamReader reader = new StreamReader(filename))
        {
            string line;

            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split('|');
                string type = parts[0];

                if (type == "Score")
                {
                    _score = int.Parse(parts[1]);
                }
                else if (type == "SimpleGoal")
                {
                    string name = parts[1];
                    string desc = parts[2];
                    int points = int.Parse(parts[3]);
                    bool isComplete = bool.Parse(parts[4]);

                    SimpleGoal goal = new SimpleGoal(name, desc, points);
                    goal.SetComplete(isComplete);
                    _goals.Add(goal);
                }
                else if (type == "EternalGoal")
                {
                    string name = parts[1];
                    string desc = parts[2];
                    int points = int.Parse(parts[3]);

                    EternalGoal goal = new EternalGoal(name, desc, points);
                    _goals.Add(goal);
                }
                else if (type == "ChecklistGoal")
                {
                    string name = parts[1];
                    string desc = parts[2];
                    int points = int.Parse(parts[3]);
                    int target = int.Parse(parts[4]);
                    int bonus = int.Parse(parts[5]);
                    int completed = int.Parse(parts[6]);

                    ChecklistGoal goal = new ChecklistGoal(name, desc, points, target, bonus);
                    goal.SetAmountCompleted(completed);
                    _goals.Add(goal);
                }
                else if (type == "Level")
                {
                    _level = int.Parse(parts[1]);
                }
                else if (type == "XP")
                {
                    _experiencePoints = int.Parse(parts[1]);
                }

            }
        }

        Console.WriteLine("Goals and score loaded successfully!");
    }

}