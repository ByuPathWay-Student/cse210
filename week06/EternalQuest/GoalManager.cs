using System.IO;
public class GoalManager
{
    List<Goal> _goals = new List<Goal>();
    private int _score;

    public GoalManager()
    {
        _score = 0;
    }

    public void Start()
    {
        string answer = "0";
        while (answer != "6")
        {
            DisplayPlayerInfo();
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("   1. Create New Goal");
            Console.WriteLine("   2. List Goals");
            Console.WriteLine("   3. Save Goals");
            Console.WriteLine("   4. Load Goals");
            Console.WriteLine("   5. Record Event");
            Console.WriteLine("   6. Quit");
            Console.Write("Select a choice from the menu: ");
            answer = Console.ReadLine();
            if (answer == "1")
            {
                CreateGoal();
            }
            else if (answer == "2")
            {
                ListGoalDetails();
            }
            else if (answer == "3")
            {
                SaveGoals();
            }
            else if (answer == "4")
            {
                LoadGoals();
            }
            else if (answer == "5")
            {
                RecordEvent();
            }
        }
        
    }
    
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.");
    }

    public void ListGoalNames()
    {
        int counter = 0;
        Console.WriteLine("The goals are:");
        foreach (Goal goal in _goals)
        {
            counter++;
            string goalName = goal._shortName;
            Console.WriteLine($"{counter}. {goalName}");
        }
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("The goals are:");
        foreach (Goal goal in _goals)
        {
            string sGoal = goal.GetDetailsString();
            Console.WriteLine(sGoal);
        }
    }

    public void CreateGoal()
    {
        string goalAnswer = "0";
        Console.WriteLine("The type of goals are:");
        Console.WriteLine("   1. Simple Goal");
        Console.WriteLine("   2. Eternal Goal");
        Console.WriteLine("   3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        goalAnswer = Console.ReadLine();
        if(goalAnswer == "1")
        {
            Console.Write("What is the name of your goal? ");
            string sGName = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string sGDescription = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            string sGPoints = Console.ReadLine();
            SimpleGoal newGoal = new SimpleGoal(sGName, sGDescription, sGPoints, false);
            _goals.Add(newGoal);
        }

        if (goalAnswer == "2")
        {
            Console.Write("What is the name of your goal? ");
            string eGName = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string eGDescription = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            string eGPoints = Console.ReadLine();
            EternalGoal newGoal = new EternalGoal(eGName, eGDescription, eGPoints);
            _goals.Add(newGoal);
        }

        if (goalAnswer == "3")
        {
            Console.Write("What is the name of your goal? ");
            string cGName = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string cGDescription = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            string cGPoints = Console.ReadLine();
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int target = Convert.ToInt32(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = Convert.ToInt32(Console.ReadLine());
            CheckListGoal newGoal = new CheckListGoal(cGName, cGDescription, cGPoints, target, bonus, 0);
            _goals.Add(newGoal);
        }
    }

    public void RecordEvent()
    {
        ListGoalNames();
        Console.Write("What goal did you accomplish? ");
        int aGoal = Convert.ToInt32(Console.ReadLine());
        int goalIndex = aGoal - 1;
        _goals[goalIndex].RecordEvent();
        _score += Convert.ToInt32(_goals[goalIndex]._points);
        Console.WriteLine($"Congratulations! You have earned {_goals[goalIndex]._points} points!");
        Console.WriteLine($"You now have {_score} points.");
        
    }

    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string file = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            outputFile.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine();
        Console.WriteLine($"You saved to {file}! You can now press 6 to quit.");
        Console.WriteLine();
    }

    public void LoadGoals()
    {
        _goals.Clear();
        Console.Write("What is the filename for the goal file? ");
        string file = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(file);
        _score = Convert.ToInt32(lines[0]);
        int skip = 0;
        foreach (string line in lines)
        {
            if (skip > 0)
            {
                string[] parts = line.Split(":");
                string goalType = parts[0];
                string goalInformation = parts[1];
                if (goalType == "SimpleGoal")
                {
                    string[] splitInfo = goalInformation.Split(",");
                    string name = splitInfo[0];
                    string description = splitInfo[1];
                    string points = splitInfo[2];
                    bool completed = Convert.ToBoolean(splitInfo[3]);
                    SimpleGoal newGoal = new SimpleGoal(name, description, points, completed);
                    _goals.Add(newGoal);
                }
                if (goalType == "EternalGoal")
                {
                    string[] splitInfo = goalInformation.Split(",");
                    string name = splitInfo[0];
                    string description = splitInfo[1];
                    string points = splitInfo[2];
                    EternalGoal newGoal = new EternalGoal(name, description, points);
                    _goals.Add(newGoal);
                }
                if (goalType == "ChecklistGoal")
                {
                    string[] splitInfo = goalInformation.Split(",");
                    string name = splitInfo[0];
                    string description = splitInfo[1];
                    string points = splitInfo[2];
                    int bonus = Convert.ToInt32(splitInfo[3]);
                    int target = Convert.ToInt32(splitInfo[4]);
                    int amountCompleted = Convert.ToInt32(splitInfo[5]);

                    
                    CheckListGoal newGoal = new CheckListGoal(name, description, points, target, bonus, amountCompleted);
                    _goals.Add(newGoal);
                }
            }
            skip++;
        }
        Console.WriteLine();
        Console.WriteLine($"You loaded from {file}!");
        Console.WriteLine();

    }
}