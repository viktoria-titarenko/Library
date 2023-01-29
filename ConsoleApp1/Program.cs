using squareLibrary;
using System.ComponentModel.DataAnnotations;

namespace Program;


class Program
{
    public static void Main()
    {
        Circle circle = new Circle(10);

        Console.WriteLine(circle.Radius);

        var result = SquareCalculator.Square(circle);
        Console.WriteLine(result);



        var triangle = new Triangle(3, 4, -5);

        var result1 = SquareCalculator.Square(triangle);

        Console.WriteLine(result1);
    }
}