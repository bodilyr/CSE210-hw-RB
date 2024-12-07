using System;
using System.Runtime.InteropServices.Marshalling;

class Program
{
    static void Main(string[] args)
    {
        //Simple test assignment
        Assignment assignment = new Assignment("Rhonda Bodily", "Fractions");

        Console.WriteLine(assignment.GetSummary());


        //math test assignment
        MathAssignment mathAssign = new MathAssignment("Steven Bodily", "Division", "5.2", "1-20 (Odd-Numbered Only)");
        Console.WriteLine();
        Console.WriteLine(mathAssign.GetSummary());
        Console.WriteLine(mathAssign.GetHomeworkList());

        //writing test assignment
        WritingAssignment writeAssign = new WritingAssignment("Sarah Bodily", "History of Rock & Roll", "How Adam Levine Got His Start");
        Console.WriteLine();
        Console.WriteLine(writeAssign.GetSummary());
        Console.WriteLine(writeAssign.GetWritingInformation());
    }
}