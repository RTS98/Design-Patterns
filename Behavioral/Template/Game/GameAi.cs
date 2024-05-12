namespace Game
{
    abstract class GameAI
    {
        public abstract void BuildStructures();
        public abstract void SendScouts();

        public void TakeTurn() => Console.WriteLine("Take Turn");

        public void CollectResources() => Console.WriteLine("Collect Resources");

        public void Attack() => Console.WriteLine("Attack");

    }
}