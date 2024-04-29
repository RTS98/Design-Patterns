using Buttons;

namespace Dialogs
{
    abstract class Dialog
    {
        protected abstract IButton CreateButton();

        public void Render()
        {
            IButton btn = CreateButton();
            btn.Render();
            btn.OnClick();
        }
    }
}
