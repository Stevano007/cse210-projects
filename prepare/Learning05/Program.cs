using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shapes> shape= new List<Shapes>();
        Circle circle= new Circle();
        Square square= new Square();
        Rectangle rectangle= new Rectangle();
        circle.SetRadius(5);
        circle.SetColor("Red");
        square.SetSides(5);
        square.SetColor("Blue");
        rectangle.SetColor("White");
        rectangle.SetLength(5);
        rectangle.SetWidth(10);
        shape.Add(circle);
        shape.Add(square);
        shape.Add(rectangle);

        foreach (Shapes s in shape){
            Console.WriteLine($"The Area of the {s.GetColor()} colored shape is {s.GetArea()} ");
        }

    }
}