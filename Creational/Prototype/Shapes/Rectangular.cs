namespace Shapes
{
    class Rectangular : Shape
    {
        public int Length;
        public int Width;

        public Rectangular(int l, int w)
        {
            Length = l;
            Width = w;

            Area = Length * Width;
        }

        private Rectangular(Rectangular rectangular) : this(rectangular.Length, rectangular.Width) { }

        public override Shape Clone() => new Rectangular(this);
    }
}