using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        
        Square square = new Square("red", 12);
        shapes.Add(square);
        Rectangle rectangle = new Rectangle("purple", 5, 9);
        shapes.Add(rectangle);
        Circle circle = new Circle("orange", 3);
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();
            Console.WriteLine($"Color: {color} Area: {area}");
        }
    }
}