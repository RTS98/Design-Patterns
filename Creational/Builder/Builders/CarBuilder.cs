namespace Builders
{
    class CarBuilder : IBuilder
    {
        Car car = new();

        public void Reset()
        {
            car = new Car();
        }

        public void SetEngine(int number)
        {
            car.Engine = number;
        }

        public void SetGPS(int number)
        {
            car.GPS = number;
        }

        public void SetSeats(int number)
        {
            car.Seats = number;
        }

        public Car GetCar()
        {
            return car;
        }
    }
}
