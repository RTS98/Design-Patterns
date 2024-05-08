namespace Components
{
    abstract class Container(string? TooltipText) : Component(TooltipText)
    {
        private Component[] children = [];

        public void Add(Container child)
        {
            children = [.. children, child];
            child.container = this;
        }
    }

    class Panel(string? ModalText) : Container(ModalText)
    {
        private readonly string? _modalText = ModalText;

        public override void ShowHelp()
        {
            if (_modalText != null)
            {
                Console.WriteLine(_modalText);
            }
            else
            {
                base.ShowHelp();
            }
        }
    }

    class Dialog(string? DialogText) : Container(DialogText)
    {
        private readonly string? _dialogText = DialogText;

        public override void ShowHelp()
        {
            if (_dialogText != null)
            {
                Console.WriteLine(_dialogText);
            }
            else
            {
                base.ShowHelp();
            }
        }
    }
}
