using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");
        Console.WriteLine();

        Square square = new Square();
        // Console.WriteLine($"{square.GetColor()}");
        // Console.WriteLine($"{square.GetArea()}");
        // Console.WriteLine();

        Rectangle rectangle = new Rectangle();
        // Console.WriteLine($"{rectangle.GetColor()}");
        // Console.WriteLine($"{rectangle.GetArea()}");
        // Console.WriteLine();

        Circle circle = new Circle();
        // Console.WriteLine($"{circle.GetColor()}");
        // Console.WriteLine($"{circle.GetArea()}");
        // Console.WriteLine();

        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shape item in shapes)
        {
            string color = item.GetColor();
            double area = item.GetArea();
            Console.WriteLine($"{color} {area}");
        }

    }
}