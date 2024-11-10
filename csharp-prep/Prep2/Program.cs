using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter your grade percentage: ");
        string gradeString = Console.ReadLine();
        int gradePercent = int.Parse(gradeString);

        string letter = "";
    
        if (gradePercent >= 90)
        {
            //Console.WriteLine ("Your grade is an A.");
            letter = "A";
        }
            else if (gradePercent >= 80)
            {
                //Console.WriteLine ("Your grade is a B.");
                letter = "B";
            }
            else if (gradePercent >= 70)
            {
            //Console.WriteLine ("Your grade is a C.");
            letter = "C";
            }
            else if (gradePercent >= 60)
            {
            //Console.WriteLine ("Your grade is a D.");
            letter = "D";
            }
            else
            {
                letter = "F";
            }
        
        Console.WriteLine ($"Your grade in this course is: {letter}");

        if (gradePercent >=70)
        {
            Console.WriteLine ("Congratulations!  You passed the class!");
        }
            else
            {
                Console.WriteLine ("Sorry you didn't pass the class.  Keep trying!");
            }
    }
}