using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapesGalore = new List<Shape>();

        Square shape1 = new Square(3, "Pink");
        shapesGalore.Add(shape1);

        Circle circle1 = new Circle("Orange" , 1);
        shapesGalore.Add(circle1);

        Rectangle rectangle1 = new Rectangle("Yellow", 5, 8);
        shapesGalore.Add(rectangle1);

    //for each loop to iterate through and get/display color and area
        foreach (Shape s in shapesGalore)
        {
            string sColor = s.GetColor();

            double sArea = s.GetArea();

            Console.WriteLine($"The {sColor} shape's area equals {sArea}!!");

        }


    }
}