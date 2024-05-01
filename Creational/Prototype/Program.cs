using Shapes;

class Program
{
    public static void Main()
    {
        Shape rectangular = new Rectangular(5, 10);

        Shape newRectangular = rectangular.Clone();

        Console.WriteLine(rectangular.GetArea() == newRectangular.GetArea()); // True
    }
}