public class Circle : Shape
{
    //member variable
    private double _radius;

    //construct to assign value to variable
    public Circle (string color, double radius) : base (color)
    {
        _radius = radius;
    }
    
    //override of GetArea() method
    public override double GetArea()
    {
        return _radius * _radius * Math.PI;
    }
}