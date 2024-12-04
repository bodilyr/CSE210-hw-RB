using System.IO;
using System.Transactions;

public class Journal
{   //list to store all user entries
    public List<Entry> _entries = new List<Entry>();

    private PromptGenerator _promptGen = new PromptGenerator();

   
    //method that adds each of the user's entries to the Entry list (above)
    public void AddEntry()
    {
       string prompt = _promptGen.GetRandomPrompt();
       Console.WriteLine(prompt);
       string entryText = Console.ReadLine();
       Entry newEntry = new Entry(promptText);
        _entries.Add(newEntry);
    }

    //create a method to display all entries (including date and prompt) for menu item #2 'Load'
    public void DisplayAll()
    {
            foreach (Entry entry in _entries)
            {
                entry.DisplayFormat();
            }
    }

    //method to save entries to a file using StreamWriter
    public void SaveToFile ()
    {   
        string fileName;
        //prompt user to enter filename used to save journal
        Console.Write("\nWhat is the Filename? (please add .txt to your chosen name) ");
        fileName = Console.ReadLine();

        //save file with user's chosen name with StreamWriter
        using (StreamWriter save = new StreamWriter(fileName))
        {
            foreach (Entry entry in _entries)
            {
                save.WriteLine($"{entry._date},{entry._promptText},{entry._entryText}");
            }
        }
        
    }

    //method to load entries saved in file (above)
    public void LoadFromFile ()
    {  
        string filePath;
        //prompt user for name of file to be loaded and tie to filePath variable
        Console.Write("What is the filename? ");
        filePath = Console.ReadLine();

        Console.WriteLine("\nCurrent contents of file loaded successfully.");

        //make sure filePath entered by user exists and then load it line by line until no more lines are left
        if (File.Exists(filePath))
        {
            using (StreamReader load = new StreamReader(filePath))
            {
                string line;
                
                while ((line = load.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 3)
                    {
                       DateTime date = DateTime.Parse(parts[0]);
                       string promptText = parts[1];
                       string entryText = parts[2];

                       //add saved entries to the Entry list
                       Entry loadedEntry = new Entry(promptText, entryText, date);

                        _entries.Add(loadedEntry);
                    }
                    
                }
            }
        }
        else
        {
            Console.WriteLine("Filename not found.");
        }
    }
}
    