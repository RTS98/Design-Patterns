using Shapes;

namespace Visitors
{
    class XMLVisitor : IVisitor
    {
        public void VisitCircle(Circle circle) => Console.WriteLine("Perform action for circle");

        public void VisitDot(Dot dot) => Console.WriteLine("Perform action for dot");
    }
}