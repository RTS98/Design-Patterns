namespace Trees
{
    class Forest
    {
        private Tree[] trees = [];

        public void PlantTree(int x, int y, string name, string color, string texture)
        {
            TreeType type = TreeFactory.GetTreeType(name, color, texture);
            Tree tree = new(x, y, type);

            trees = [.. trees, tree];
        }

        public void Draw()
        {
            foreach (Tree tree in trees)
            {
                tree.Draw();
            }
        }
    }
}