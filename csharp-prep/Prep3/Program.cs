using System;

class Program
{
    static void Main(string[] args)
    {
        /*Console.Write("What is the magic number? ");
        string userInput = Console.ReadLine();
        int magicNumber = int.Parse(userInput);
        */
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1,101);
        //Console.WriteLine ($"{magicNumber}");

        int guessNumber = 0;
        do
        {
            Console.Write("What is your guess? ");
            string userGuess = Console.ReadLine();
            guessNumber = int.Parse(userGuess);

            if (guessNumber > magicNumber)
            {
                Console.WriteLine ("Lower");
            }
                else if (guessNumber < magicNumber)
                {
                    Console.WriteLine ("Higher");
                }
                else
                {
                    Console.WriteLine ("You guessed it correctly!");
                }
        }while (guessNumber != magicNumber);
        
    }
}