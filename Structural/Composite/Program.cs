using Graphics;

class Program
{
    public static void Main(string[] args)
    {
        CompoundGraphic list = new();

        list.Add(new Dot(1, 5));
        list.Add(new Dot(2, 3));
        list.Add(new Dot(2, 6));
        list.Add(new Dot(3, 4));

        list.Draw(); // draws all the components
    }
}