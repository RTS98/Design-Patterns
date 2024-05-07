using Trees;

class Program
{
    public static void Main(string[] args)
    {
        Forest forest = new();

        forest.PlantTree(2, 6, "Black Forest", "Black", "Mountain");

        forest.Draw();
    }
}