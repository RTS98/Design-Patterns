namespace Checkboxes
{
    class MacCheckbox : ICheckbox
    {
        public void Render() => Console.WriteLine("Rendering on Mac");

        public void OnClick() => Console.WriteLine("OnClick - Mac");
    }
}