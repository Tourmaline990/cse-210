using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");
        Square square = new Square("black",5);
        Console.WriteLine($"Area of a {square.GetColor()} Square is {square.GetArea()} ");
        Rectangle rectangle = new Rectangle("Gold",5,6);
        Console.WriteLine($" Area of a {rectangle.GetColor()} Rectangle is {rectangle.GetArea()}");
        Circle circle =  new Circle("Purple",12);
        Console.WriteLine($"Area of a {circle.GetColor()} Circle is {circle.GetArea()} ");


        List<Shape> shapes = new List<Shape>();
         shapes.Add(square);
         shapes.Add(rectangle);
         shapes.Add(circle);

         foreach (Shape item in shapes)
         {
            Console.WriteLine(item.GetArea());
            Console.WriteLine(item.GetColor());
         }
    }
}