using System;

/*
=======================================
||                                   ||
||  My extra coding effort was       ||
||  making sure only words that were ||
||  "showing" were being chosen by   ||
||  the word randomizer method.      ||    
||                                   ||
=======================================
*/
class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("2 Nephi", 4, 20, 21);
        Scripture scripture = new Scripture(reference, "My God hath been my support; he hath led me through mine afflictions in the wilderness; and he hath preserved me upon the waters of the great deep. He hath filled me with his love, even unto the consuming of my flesh.");
        
        while (true)
        {
           Console.Clear();

           Console.WriteLine(scripture.GetDisplayText());
           Console.WriteLine("\nPlease press Enter to hide random words, or type 'quit' to exit the program.");
           string userInput = Console.ReadLine();

           if (userInput.ToLower() == "quit")
           {
                break;
           }

            scripture.HideRandomWords(3);

            if (scripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                break;
            }
        }
    }
}