using Shapes;

namespace Visitors
{
    interface IVisitor
    {
        public void VisitDot(Dot dot);
        public void VisitCircle(Circle circle);
    }
}