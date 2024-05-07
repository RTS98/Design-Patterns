namespace Trees
{
    class Tree(int x, int y, TreeType type)
    {
        private readonly int _x = x;
        private readonly int _y = y;
        private readonly TreeType _type = type;

        public int X => _x;
        public int Y => _y;

        public void Draw() => _type.Draw(_x, _y);
    }
}