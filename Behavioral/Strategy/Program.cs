using Strategy;

class Program
{
    public static void Main(string[] args)
    {
        Context context = new(new RoadStrategy());

        context.BuildRoute();
    }
}