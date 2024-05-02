namespace Graphics
{
    class Dot(int x, int y) : IGraphic
    {
        private int X = x;
        private int Y = y;

        public void Draw()
        {
            Console.WriteLine($"Coords: {X}, {Y}");
        }

        public void Move(int x, int y)
        {
            X += x;
            Y += y;
        }
    }
}