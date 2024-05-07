namespace Trees
{
    class TreeType(string name, string color, string texture)
    {
        private readonly string _name = name;
        private readonly string _color = color;
        private readonly string _texture = texture;

        public string Name => _name;
        public string Color => _color;
        public string Texture => _texture;

        public void Draw(int x, int y)
        {
            Console.WriteLine($"Createing a map with color {_color} and texture {_texture}");
            Console.WriteLine($"Drawing {x} and {y}");
        }
    }
}