using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Xml;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
      

       //instantiate Journal object/class
       Journal myJournal = new Journal();
       
       
       
       string userOption = "";
       Console.Clear();
        
       do
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\n\n\nWelcome to the Joy of Journaling Program!\r\n");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Please select one of the following options:\n");
            Console.ResetColor();
            Console.WriteLine("1.  Write");
            Console.WriteLine("2.  Display");
            Console.WriteLine("3.  Load");
            Console.WriteLine("4.  Save");
            Console.WriteLine("5.  Quit\n\n");
            Console.Write("Choose an option: ");
            userOption = Console.ReadLine();
            
            switch (userOption)   
            {
                case "1":
                   
                    //add new entry to journal
                    myJournal.AddEntry();

                    //tell user their entry has been recorded
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("\nYour entry has been successfully recorded.");
                    Console.ResetColor();
                break;

                case "2":
                    //menu option Display
                    //display all journal entries
                    myJournal.DisplayAll();
                break;

                case "3":
                    //menu option Load
                    //load journal from a saved file
                    myJournal.LoadFromFile();
                break;
            
                case "4":
                    //menu option Save
                    myJournal.SaveToFile();
                    //let user know file was saved
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("\nYour file has been successfully saved.");
                    Console.ResetColor();
                break;

                case "5":
                    //menu option Save & Quit
                    //quit Joy of Journaling program with autosave
                    //myJournal.SaveToFile();

                    //Goodbye message to user
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("\nGoodbye for now!");
                    Console.ResetColor();
                break;

                default:
                    Console.WriteLine("Unrecognized option. Please try again.");
                    break;
            }
                      
                Console.WriteLine("\nPress ENTER to continue...\n\n");
                Console.ReadKey();  
            

        }while (userOption != "5");

    }
}
