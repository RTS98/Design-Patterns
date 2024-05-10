class Program
{
    public static void Main(string[] args)
    {
        Originator originator = new();
        CareTaker careTaker = new(originator);

        careTaker.PerformAction();
    }
}