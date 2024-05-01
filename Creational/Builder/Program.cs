using Builders;

class Program
{
    public static void Main()
    {
        CarBuilder carBuilder = new();

        Director.MakeSportCar(carBuilder);

        Console.WriteLine(carBuilder.GetCar());
    }
}