using Strategy;

class Context(IStrategy strategy)
{
    private IStrategy _strategy = strategy;

    public void ChangeStrategy(IStrategy strategy) => _strategy = strategy;

    public void BuildRoute() => _strategy.CalculateRoute();
}