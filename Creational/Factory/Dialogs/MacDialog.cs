using Buttons;

namespace Dialogs
{
    class MacDialog : Dialog
    {
        protected override IButton CreateButton()
        {
            return new MacButton();
        }
    }
}