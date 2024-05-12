using Visitors;

namespace Shapes
{
    class Dot : IShape
    {
        public void Accept(IVisitor visitor) => visitor.VisitDot(this);

        public void Draw() => Console.WriteLine("Drawing dot");

        public void Move(int x, int y) => Console.WriteLine($"Moving dot to {x} and {y}");
    }
}