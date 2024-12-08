public class Activity
{
    //member variables in common with all activities
    private string _name;
    private string _description;
    private int _duration;

    //constructor to assign values to variables
    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    //methods/functions in common
    public int GetDuration()
    {
        return _duration;
    }
    
    public void DisplayStartMessage()
    {
        Console.WriteLine($"Welcome to the {_name}:  {_description}\n");
        Console.WriteLine();
        Console.WriteLine("Prepare to start");
        Thread.Sleep (3000);
        ShowCountDown(3);  
    }

    public void DisplayEndMessage()
    {
        Console.WriteLine("Well done!!");
        ShowSpinner(5);
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
        ShowSpinner(5);
    }

    public void ShowSpinner(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write("*");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine();
    }

}