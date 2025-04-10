using System;
using System.Collections.ObjectModel;

class Program
{
    static void Main(string[] args)
    {
        SquareShape square = new SquareShape(5, "red");
        // square.SetColor("Red");

        RectangleShape rectangle = new RectangleShape(5, 10, "blue");

        CircleShape circle = new CircleShape(5, "green");

        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Shape Color: {shape.GetColor()}, Area: {shape.Area()}");
        }


    }
}