public class Rectangle : Shape
{
    //member variables
    private double _length;
    private double _width;

    //constructor to assign value to variables
    public Rectangle(string color, double length, double width) : base (color)
    {
        _length = length;
        _width = width;
    }
    //override GetArea() method 
    public override double GetArea()
    {
        return _length * _width;
    }


}