namespace Buttons
{
    class MacButton : IButton
    {
        public void Render() => Console.WriteLine("Rendering on Mac");

        public void OnClick() => Console.WriteLine("OnClick - Mac");
    }
}