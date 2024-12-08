using System.Runtime.CompilerServices;

public class ReflectingActivity : Activity
{
    //member variables
    private List<string> _prompts;
    private List<string> _questions;

    //constructor - assign values to variables
    public ReflectingActivity(string name, string description, int duration, List<string> prompts, List<string> questions)
        : base(name, description, duration)
    {
        _prompts = prompts;
        _questions = questions;
    }

    //methods & functions
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    public string GetRandomQuestion()
    {
        Random random = new Random();
        int index = random.Next(_questions.Count);
        return _questions[index];
    }

    public void DisplayPrompt()
    {
        Console.WriteLine("Reflect on the following prompt:");
        Console.WriteLine(GetRandomPrompt());
        ShowSpinner(3);
        Console.WriteLine("Press Enter once you are ready to continue.");
        Console.ReadLine();
    }

    public void DisplayQuestions()
    {
        Console.WriteLine("Consider the following questions:");
        foreach (var question in _questions)
        {
            Console.WriteLine(question);
        }
    }

    public void Run()
    {
        DisplayStartMessage();
        DisplayPrompt();

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());
        while (DateTime.Now < endTime)
        {
            Console.WriteLine (GetRandomQuestion());
            ShowSpinner(10);
        }
        DisplayEndMessage();
    }

}




