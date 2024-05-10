using Components;

class Program
{
    public static void Main(string[] args)
    {
        AutheticationDialog autheticationDialog = new();
        Button button = new(autheticationDialog);

        button.Click();
    }
}