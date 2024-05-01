namespace Shapes
{
    class Circle : Shape
    {
        public int Radius;

        public Circle(int radius) : base()
        {
            Radius = radius;
            
            Area = Math.Pow(radius * Math.PI, 2);
        }

        private Circle(Circle circle) : this(circle.Radius) { }

        public override Shape Clone() => new Circle(this);
    }
}