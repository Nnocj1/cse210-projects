using System;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Shape Area Calculator");
        Console.WriteLine("Menu Options:");
        Console.WriteLine(" 1. Square.\n 2. Rectangle. \n3. Circle.");
        string color ="red";
        double side = 4;
        Square newSquare = new Square(side, color );
        Console.WriteLine(newSquare.GetColor());
        Console.WriteLine(newSquare.GetArea());

        List<Shape> shapes = new List<Shape>();
        
        Square square1 = new Square(4, "Yellow" );
        shapes.Add(square1);

        Rectangle rectangle1 = new Rectangle(4, 6, "Pink" );
        shapes.Add(rectangle1);

        Circle circle1 = new Circle(14,"Pink" );
       shapes.Add(circle1);

        foreach (Shape shape in shapes )
        {
            Console.WriteLine($"Shape color:{shape.GetColor()}, Area: {shape.GetArea()}");
        }
        
    }

}



