namespace Components
{
    class Component(IMediator dialog)
    {
        private readonly IMediator _dialog = dialog;

        public void Click() => _dialog.Notify(this, EventType.Click);
        public void KeyPress() => _dialog.Notify(this, EventType.KeyPress);
    }

    class Button(IMediator dialog) : Component(dialog) { }

    class TextBox(IMediator dialog) : Component(dialog) { }
}
