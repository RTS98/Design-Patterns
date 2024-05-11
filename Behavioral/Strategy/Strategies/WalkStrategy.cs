namespace Strategy
{
    class WalkStrategy : IStrategy
    {
        public void CalculateRoute() => Console.WriteLine("Calculate route when walking");
    }
}