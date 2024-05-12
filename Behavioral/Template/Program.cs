using Game;

class Program
{
    public static void Main(string[] args)
    {
        GameAI game = new MonstersAI();

        game.BuildStructures();
    }
}