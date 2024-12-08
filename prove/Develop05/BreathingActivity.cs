using System.Security.Principal;

public class BreathingActivity : Activity
{
    //no member variables

    //constructor - assign values to base 
    public BreathingActivity(string name, string description, int duration)
        : base(name, description, duration)
    {
    }

    //method/function
    public void Run()
    {
        DisplayStartMessage();

        int duration = GetDuration();
        DateTime endTime = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            Console.Write($"Breath in...");
            ShowCountDown(4);
            Console.WriteLine();

            Console.Write($"Breath out..."); 
            ShowCountDown(5);
            Console.WriteLine();
        }

        DisplayEndMessage();
    }

}