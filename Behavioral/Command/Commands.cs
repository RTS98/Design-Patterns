using Editors;

namespace Commands
{
    abstract class Command(IEditor editor)
    {
        protected IEditor Editor = editor;
        abstract public void Execute();
    }

    class SaveCommand(IEditor editor) : Command(editor)
    {
        public override void Execute() => Editor.Save();
    }

    class OpenCommand(IEditor editor) : Command(editor)
    {
        public override void Execute() => Editor.Open();
    }

    class PrintCommand(IEditor editor) : Command(editor)
    {
        public override void Execute() => Editor.Print();
    }
}

