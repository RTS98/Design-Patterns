using Visitors;

namespace Shapes
{
    class Circle : IShape
    {
        public void Accept(IVisitor visitor) => visitor.VisitCircle(this);

        public void Draw() => Console.WriteLine("Drawing cirlce");

        public void Move(int x, int y) => Console.WriteLine($"Moving circle to {x} and {y}");
    }
}