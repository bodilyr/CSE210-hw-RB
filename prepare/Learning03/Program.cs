using System;

class Program
{
    static void Main(string[] args)
    {
        //create an instance using first constructor that returns 1/1
        Fraction fraction1 = new Fraction();
        

        //create an instance using second constructor that returns 6/1
        Fraction fraction2 = new Fraction(6);

        //create an instance using third constructor that returns 6/7
        Fraction fraction3 = new Fraction(6,7);


        //verify you can call setters to change values and then getters to retrieve these new values and then display them to the console.

        Fraction f10 = new Fraction();
        f10.SetTop(3);
        f10.SetBottom(4);
        Console.WriteLine($"\nThe new fraction is now {f10.GetTop()}/{f10.GetBottom()}\n");
        

        //verify constructors GetFractionString and GetDecimalValue work using the following values: 1, 5, 3/4, 1/3
        Fraction f1 = new Fraction();
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());

        Fraction f2 = new Fraction(5);
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());

        Fraction f3 = new Fraction(3,4);
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());

        Fraction f4 = new Fraction(1,3);
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());

    }
}