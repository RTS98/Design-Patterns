using Visitors;

namespace Shapes
{
    interface IShape
    {
        public void Draw();
        public void Move(int x, int y);

        public void Accept(IVisitor visitor);
    }
}