namespace Builders
{
    class ManualBuilder : IBuilder
    {
        Manual manual = new();

        public void Reset()
        {
            manual = new Manual();
        }

        public void SetEngine(int number)
        {
            manual.Engine = number;
        }
        
        public void SetGPS(int number)
        {
            manual.GPS = number;
        }

        public void SetSeats(int number)
        {
            manual.Seats = number;
        }

        public Manual GetManual()
        {
            return manual;
        }
    }
}
