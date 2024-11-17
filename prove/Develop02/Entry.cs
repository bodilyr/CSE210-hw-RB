public class Entry
{
    //stores date of entry
    public DateTime _date;

    //stores journal prompt randomly assigned to user
    public string _promptText;

    //stores user's response to the random prompt
    public string _entryText;


//constructor that grabs random prompt input and assigns to _promptText member variable
public Entry(string promptText)
{

_promptText = promptText;

}
//method to display the user's prompt, read user entry, and record date of entry
public void DisplayPrompt()
    {
        Console.WriteLine($"{_promptText}\r");
        _entryText = Console.ReadLine();
        _date = DateTime.Now;
    }

//method to pull together the format of what will be displayed to user 
public void DisplayFormat()
    {
        Console.WriteLine($"Date: {_date}   Prompt: {_promptText}");
        Console.WriteLine($"Entry: {_entryText}");
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~\n");
    }
}


    

