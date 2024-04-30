using Buttons;
using Checkboxes;
using Factories;

class MacFactory : IGUIFactory
{
    public IButton CreateButton() => new MacButton();
    
    public ICheckbox CreateCheckbox() => new MacCheckbox();

}