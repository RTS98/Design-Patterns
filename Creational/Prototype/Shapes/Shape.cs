namespace Shapes
{
    abstract class Shape
    {
        protected double Area;
        abstract public Shape Clone();
        public double GetArea() => Area;
    }
}