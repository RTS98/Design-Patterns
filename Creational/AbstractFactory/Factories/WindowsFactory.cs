using Buttons;
using Checkboxes;
using Factories;

class WindowsFactory : IGUIFactory
{
    public IButton CreateButton() => new WindowsButton();

    public ICheckbox CreateCheckbox() => new WindowsCheckbox();

}