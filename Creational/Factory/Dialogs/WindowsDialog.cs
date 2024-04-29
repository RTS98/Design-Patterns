using Buttons;

namespace Dialogs
{
    class WindowsDialog : Dialog
    {
        protected override IButton CreateButton()
        {
            return new WindowsButton();
        }
    }
}