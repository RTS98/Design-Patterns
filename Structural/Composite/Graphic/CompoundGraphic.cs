namespace Graphics
{
    class CompoundGraphic
    {
        private IGraphic[] Children = [];

        public void Add(IGraphic child)
        {
            Children = [.. Children, child];
        }

        public void Remove(IGraphic child)
        {
            Children = Children.Where((IGraphic element) => element != child).ToArray();
        }

        public void Move(int x, int y)
        {
            foreach (IGraphic child in Children)
            {
                child.Move(x, y);
            }
        }

        public void Draw()
        {
            foreach (IGraphic child in Children)
            {
                child.Draw();
            }
        }
    }
}