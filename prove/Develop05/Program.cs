using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        List<string> prompts = new List<string> { "Think about a time when you were at peace.", "Recall a moment when you felt satisfaction in an achievement."};
        List<string> questions = new List<string> { "What did you learn from this experience?", "How did it make you feel?"};

        bool mindful = true;

        while (mindful)
        {
            Console.WriteLine("Choose a Mindfulness activity");
            Console.WriteLine("1.  Breathing Activity");
            Console.WriteLine("2.  Listing Activity");
            Console.WriteLine("3.  Reflecting Activity");
            Console.WriteLine("4.  Quit");
            Console.Write("Enter your choice: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Please enter the duration for the Breathing Activity in seconds: ");
                    int breathDuration = int.Parse(Console.ReadLine());
                    
                    BreathingActivity breathingActivity = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", breathDuration);
                    Console.WriteLine();                    
                    breathingActivity.Run();
                break;

                case "2":
                    Console.Write("Please enter the duration for the Listing Activity in seconds: ");
                    int listDuration = int.Parse(Console.ReadLine());

                    ListingActivity listActivity = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", listDuration, prompts);
                    Console.WriteLine();
                    listActivity.Run();
                break;

                case "3":
                    Console.Write("Please enter the duration for the Reflecting Activity in seconds: ");
                    int reflectDuration = int.Parse(Console.ReadLine());

                    ReflectingActivity reflectActivity = new ReflectingActivity ("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", reflectDuration, prompts, questions);
                    Console.WriteLine();
                    reflectActivity.Run();
                break;

                case "4":
                    mindful = false;
                    Console.WriteLine("Thanks for taking the time to practice mindfulness!!");
                break;

                default:
                    Console.WriteLine("Invalid choice.  Please try again.");
                break;
            }
            Console.WriteLine();
        }

    }
}