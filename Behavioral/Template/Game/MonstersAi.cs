namespace Game
{
    class MonstersAI : GameAI
    {
        public override void BuildStructures() => Console.WriteLine("Build Structures for Monsters");

        public override void SendScouts() => Console.WriteLine("Send Scouts for Monsters");
    }
}