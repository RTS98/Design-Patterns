namespace Buttons
{
    class WindowsButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("Rendering on Windows");
        }

        public void OnClick()
        {
            Console.WriteLine("OnClick - Windows");
        }
    }
}