public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    private string _userInput;
    

    public GoalManager()
    {
        _score = 0;
    }

    public string GetUserInput()
    {
        return _userInput;
    }

    public string UserSelection()
    {
        Console.WriteLine("Menu Options:");
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
        UserSelection();
        if (_userInput == "1")
        {

            return "Create New Goal";
        }
        else if (_userInput == "2")
        {

            return "List Goals";
        }
        else if (_userInput == "3")
        {

            return "Save Goals";
        }
        else if (_userInput == "4")
        {

            return "Load Goals";
        }
        else if (_userInput == "5")
        {

            return "Record Events";
        }
        else if (_userInput == "6")
        {
            Console.WriteLine("Exiting the program. Thanks for participating!");
            return "Exit";
        }
        else
        {
            return "Invalid selection. Please try again.";
        }
    }

    public void Start()
    {

    }

    public void DisplayPlayerInfo()
    {

    }

    public void ListGoalNames()
    {

    }

    public void ListGoalDetails()
    {

    }

    public void CreateGoal()
    {

    }

    public void RecordEvent()
    {

    }

    public void SaveGoals()
    {

    }

    public void LoadGoals()
    {

    }
}