using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("Red", 8);
        Rectangle rectangle= new Rectangle("Yellow", 8, 10);
        Cirle cirle = new Cirle("Blue",100);

        List<Shapes> shapes = new List<Shapes>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(cirle);
        

        foreach (Shapes shape in shapes)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
        }
    }
}