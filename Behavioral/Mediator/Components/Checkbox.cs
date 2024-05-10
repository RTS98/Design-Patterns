namespace Components
{
    class CheckBox(IMediator dialog) : Component(dialog)
    {
        private readonly IMediator _dialog = dialog;
        public void Check() => _dialog.Notify(this, EventType.Check);
    }
}