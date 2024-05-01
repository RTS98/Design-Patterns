namespace Builders
{
    interface IBuilder
    {
        public void Reset();

        public void SetSeats(int number);

        public void SetEngine(int number);

        public void SetGPS(int number);
    }
}
