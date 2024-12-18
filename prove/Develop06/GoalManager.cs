using System.Formats.Asn1;
using System.IO.Compression;
using System.Runtime;
using System.Xml.Serialization;
using Microsoft.VisualBasic;
using System.Collections;

public class GoalManager
{
    //member variables
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    //functions and methods used for menu
    public void Start()
    {
        while (true)
        {
            DisplayMenu();
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateGoal();
                    break;

                case "2":
                    ListGoalDetails();
                    break;

                case "3":
                    SaveGoals("goals.txt");
                    break;

                case "4":
                    LoadGoals("goals.txt");
                    break;

                case "5":
                    RecordEvent();
                    break;

                case "6":
                    Console.WriteLine("Exiting....");
                    return;

                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }
        }
    }

    private void DisplayMenu()
    {

        Console.WriteLine();
        Console.WriteLine($"You have {_score} points.");
        Console.WriteLine();
        Console.WriteLine("M E N U");
        Console.WriteLine();
        Console.WriteLine("1.   Create New Goal");
        Console.WriteLine("2.   List Goals");
        Console.WriteLine("3.   Save Goals");
        Console.WriteLine("4.   Load Goals");
        Console.WriteLine("5.   Record Event");
        Console.WriteLine("6.   Quit");
        Console.WriteLine();
        Console.Write("Choose an option:  ");
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Score:  {_score}");
    }

    public void ListGoalNames()
    {
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetStringRepresentation());
        }
    }

    public void ListGoalDetails()
    {
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("Select goal type:");
        Console.WriteLine("");
        Console.WriteLine("1.   Simple Goal");
        Console.WriteLine("2.   Eternal Goal");
        Console.WriteLine("3.   Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string choice = Console.ReadLine();

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();

        Console.Write("Enter a short description of your goal:  ");
        string description = Console.ReadLine();

        Console.Write("Enter the point value of your goal:  ");
        int points = int.Parse(Console.ReadLine());

        Goal goal = null;
        switch (choice)
        {
            case "1":
                goal = new SimpleGoal(name, description, points);
                break;

            case "2":
                goal = new EternalGoal(name, description, points);
                break;

            case "3":
                Console.Write("How many times do you want to accomplish this goal? ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("How many bonus points for 'meeting' all the requirements of this goal? ");
                int bonus = int.Parse(Console.ReadLine());
                goal = new ChecklistGoal(name, description, points, target, bonus);
                break;

            default:
                Console.WriteLine("Invalid choice, please try again!");
                return;
        }
        _goals.Add(goal);
    }
    public void RecordEvent()
    {
        Console.WriteLine("Select goal to record accomplishment: ");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetStringRepresentation()}");
        }
        int choice = int.Parse(Console.ReadLine()) -1;
        if (choice >= 0 && choice < _goals.Count)
        {
            Goal goal = _goals[choice];
            goal.RecordEvent();
            _score += goal.Points;

            if (goal is ChecklistGoal checklistGoal && checklistGoal.IsComplete())
            {
                _score += checklistGoal.Bonus;
            }
        }
        else
        {
            Console.WriteLine("Invalid choice, please try again!");
        }
    }

public void SaveGoals(string filePath)
{   using (StreamWriter writer = new StreamWriter(filePath))
    {
        writer.WriteLine(_score);
        foreach (var goal in _goals)
        {    
            writer.WriteLine(goal.GetStringRepresentation());
        }
    }   
}
public void LoadGoals(string filePath)
{
    using (StreamReader reader = new StreamReader(filePath))
    {
        _score = int.Parse(reader.ReadLine());
        while (!reader.EndOfStream)
        {
            string[] data = reader.ReadLine().Split(',');
            string type = data[0];
            switch (type)
            {
                case "SimpleGoal":
                    _goals.Add(new SimpleGoal(data[1], data[2], int.Parse(data[3]))); //{ SimpleGoal.IsComplete() = bool.Parse(data[4]) });
                    break;

                case "EternalGoal":
                    _goals.Add(new EternalGoal(data[1], data[2], int.Parse(data[3])));
                    break;

                case "ChecklistGoal":
                    _goals.Add(new ChecklistGoal(data[1], data[2], int.Parse(data[3]), int.Parse(data[4]), int.Parse(data[5])) );
                    break;
            }
        }
    }
}



}
