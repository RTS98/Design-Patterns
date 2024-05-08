using Components;

class Program
{
    public static void Main(string[] args)
    {
        Dialog dialog = new("Info Dialog");
        Panel panel = new("Panel Tooltip");
        Panel newPanel = new(null);
        dialog.Add(panel);
        dialog.Add(newPanel);

        panel.ShowHelp(); // Panel Tooltip
        newPanel.ShowHelp(); // Info Dialog
    }
}