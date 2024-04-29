using Dialogs;

class Program
{
    public static void Main(string[] args)
    {
        Dialog dialog = new MacDialog();
        dialog.Render();

        dialog = new WindowsDialog();
        dialog.Render();
    }
}