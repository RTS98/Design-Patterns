using Buttons;
using Checkboxes;
using Factories;

class Client(IGUIFactory f)
{
    readonly IGUIFactory factory = f;
    IButton? button;
    ICheckbox? checkbox;

    public void CreateButton()
    {
        button = factory.CreateButton();
        button.Render();
    }

    public void CreateCheckbox()
    {
        checkbox = factory.CreateCheckbox();
        checkbox.Render();
    }

    public void OnClickButton() => button?.OnClick();

    public void OnClickCheckbox() => checkbox?.OnClick();
}
