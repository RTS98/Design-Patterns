using Builders;

class Director
{
    public static void MakeSportCar(IBuilder builder)
    {
        builder.Reset();
        builder.SetEngine(47);
        builder.SetSeats(2);
        builder.SetGPS(0);
    }

    public static void MakeSuvCar(IBuilder builder)
    {
        builder.Reset();
        builder.SetEngine(48);
        builder.SetSeats(7);
        builder.SetGPS(2);
    }
}