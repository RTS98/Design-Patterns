namespace Strategy
{
    class PublicTransportationStrategy : IStrategy
    {
        public void CalculateRoute() => Console.WriteLine("Calculate route when taking public transportation");
    }
}