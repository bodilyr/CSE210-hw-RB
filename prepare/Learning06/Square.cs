public class Square : Shape
{
    //member variable
    private double _side;

    //constructor to assign value to variables
    public Square(double side, string color) : base(color)
    {
        _side = side;
    }

    //GetArea() method override
    public override double GetArea()
    {
        return _side * _side;
    }
}

