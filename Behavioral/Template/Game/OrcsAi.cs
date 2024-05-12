namespace Game
{
    class OrcsAI : GameAI
    {
        public override void BuildStructures() => Console.WriteLine("Build Structures for Orcs");

        public override void SendScouts() => Console.WriteLine("Send Scouts for Orcs");
    }
}