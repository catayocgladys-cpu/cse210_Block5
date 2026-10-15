using System;

using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");

        Square square = new Square("Blue", 5);
        Rectangle rectangle = new Rectangle("Red", 4, 6);
        Circle circle = new Circle("Green", 3);

        Console.WriteLine();
        Console.WriteLine("Testing individual shapes:");

        Console.WriteLine($"Square color: {square.GetColor()}");
        Console.WriteLine($"Square area: {square.GetArea()}");

        Console.WriteLine($"Rectangle color: {rectangle.GetColor()}");
        Console.WriteLine($"Rectangle area: {rectangle.GetArea()}");

        Console.WriteLine($"Circle color: {circle.GetColor()}");
        Console.WriteLine($"Circle area: {circle.GetArea()}");

        Console.WriteLine();
        Console.WriteLine("Testing polymorphism:");

        List<Shape> shapes = new List<Shape>();

        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Color: {shape.GetColor()}, Area: {shape.GetArea()}");
        }
    }
}