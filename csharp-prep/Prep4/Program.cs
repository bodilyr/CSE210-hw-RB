using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {   
        //create new list of integers 
        List<int> numbers = new List<int>();

        //user instructions
        Console.WriteLine("Enter a list of numbers, type 0 to quit.");

        //define userInput datatype
        int userInput = -1;

        //prompt user to enter numbers
        while (userInput != 0)
        {
            Console.Write ("Enter a number:  ");
            string userString = Console.ReadLine();
            userInput = int.Parse(userString);
        

        //add user-entered number to numbers list ONLY if not 0
        if (userInput != 0)
        {
            numbers.Add(userInput);
        }
        }
        
        //calculate the sum of all user-entered numbers
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum of numbers in the list is {sum}.");

        //calculate the average of all user-entered numbers
        float average = ((float)sum / numbers.Count);

        Console.WriteLine($"The average of numbers in the list is {average}.");

        //calculate the highest number(max) of all user-entered numbers
        int max = numbers[0];
        
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The max (largest) number in the list is {max}.");

    }
}