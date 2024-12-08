public class ListingActivity : Activity
{
    //member variables
    private int _count;
    private List<string> _prompts;

    //constructor - assign values to variables
    public ListingActivity(string name, string description, int duration, List<string> prompts)
        : base (name, description, duration)
    {
        _prompts = prompts;
        _count = _prompts.Count;
    }

    //Methods & Functions

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_count);
        return _prompts[index];
    }

    public void Run()
    {
        DisplayStartMessage();

        Console.WriteLine("Here is your prompt.  Get ready to type!");
        
        Console.WriteLine(GetRandomPrompt());
        ShowCountDown(10);

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());
        List<string> userList = new List<string>();
        Console.WriteLine("Start listing items.");

        while (DateTime.Now < endTime)
        {
            Console.Write("^ ");
            string item = Console.ReadLine();
            userList.Add(item);
        }

        Console.WriteLine("You listed: ");
        foreach (var item in userList)
        {
            Console.WriteLine(item);
        }

        DisplayEndMessage();

    }
}