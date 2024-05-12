using Shapes;
using Visitors;

class Program
{
    public static void Main(string[] args)
    {
        IVisitor visitor = new XMLVisitor();
        IShape[] shapes = [new Circle(), new Dot()];

        foreach (IShape shape in shapes)
        {
            shape.Accept(visitor);
        }
    }
}