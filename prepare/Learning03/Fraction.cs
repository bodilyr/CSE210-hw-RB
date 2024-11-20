public class Fraction
{
    //attribute for top number
    private int _top;

    //attribute for bottom number
    private int _bottom;

    //constructors
    //no parameters that initializes the number to 1/1.
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
        
        //Console.WriteLine($"\nHere is your fraction: {_top}/{_bottom}\n");
    }

    //one parameter for the top; bottom initialized to 1
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;

        //Console.WriteLine($"\nHere is your fraction: {_top}/{_bottom}\n");
    }

    // two parameters, one for the top and one for the bottom.
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;

        //Console.WriteLine($"\nHere is your fraction: {_top}/{_bottom}\n");
    }

    //create getters and setters for top number
    public int GetTop()
    {
        return _top;
    }

    public void SetTop(int top)
    {
        _top = top;
        //Console.WriteLine($"The variable _top is now equal to {_top}");
    }
        //create getters and setters for bottom number
        public int GetBottom()
        {
            return _bottom;
            
        }

        public void SetBottom(int bottom)
        {
            _bottom = bottom;
            //Console.WriteLine($"The variable _bottom is now equal to {_bottom}");
        }

        //Create a method called GetFractionString that returns the fraction in the form 3/4.
        public string GetFractionString()
        {
           string toText = $"{_top}/{_bottom}";
           return toText;
        }

        //Create a method called GetDecimalValue that returns a double that is the result of dividing the top number by the bottom number, such as 0.75.
        public double GetDecimalValue()
        {
            return (double)_top/(double)_bottom;
        }

}