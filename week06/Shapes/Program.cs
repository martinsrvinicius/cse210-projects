using System;
using System.Drawing;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");

        Square sq = new Square("Red", "MySquare", 5.0);
        Rectangle r = new Rectangle("Blue", "MyRectangle", 4.0, 6.0);
        Circle c = new Circle("Green", "MyCircle", 3.0);


        List<Shape> shapes = new List<Shape>();
        shapes.Add(sq);
        shapes.Add(r);
        shapes.Add(c);

        foreach (Shape s in shapes)
        {
            Console.WriteLine($"Shape: {s.GetName()}, Color: {s.GetColor()}, Area: {s.GetArea()}");
        }
    }
}