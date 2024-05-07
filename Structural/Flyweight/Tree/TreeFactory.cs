namespace Trees
{
    class TreeFactory
    {
        public static TreeType[] types = [];

        public static TreeType GetTreeType(string name, string color, string texture)
        {
            TreeType? type = types
                .Where((TreeType element) => element.Color == color && element.Name == name && element.Texture == texture)
                .ToArray()
                .FirstOrDefault();

            if (type == null)
            {
                type = new TreeType(name, color, texture);
                types = [.. types, type];
            }

            return type;
        }
    }
}