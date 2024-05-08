namespace Editors
{
    interface IEditor
    {
        void Save();
        void Open();
        void Print();
    }

    class Editor : IEditor
    {
        public void Save() => Console.WriteLine("Saving...");
        public void Open() => Console.WriteLine("Opening...");
        public void Print() => Console.WriteLine("Printing...");
    }
}