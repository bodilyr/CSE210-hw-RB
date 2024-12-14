using System.Drawing;

public class Shape
{
    //member variables
    protected string _color;

    //constructor to assign value to variables
    public Shape(string color)
    {
        _color = color;
    }

    //Get and Set methods
    public void SetColor(string color)
    {
        _color = color;
    }

    public string GetColor()
    {
        return _color;
    }

    //virtual method for GetArea()
    public virtual double GetArea()
    {
        return 0.0;
    }
}