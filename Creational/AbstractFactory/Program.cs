class Program
{
    public static void Main(string[] args)
    {
        Client client = new(new MacFactory());

        client.CreateButton();
        client.OnClickButton();
    }
}