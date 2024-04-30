namespace Checkboxes
{
    class WindowsCheckbox : ICheckbox
    {
        public void Render() => Console.WriteLine("Rendering on Windows");

        public void OnClick() => Console.WriteLine("OnClick - Windows");
    }
}