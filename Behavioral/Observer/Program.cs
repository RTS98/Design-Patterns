using EventListeners;

class Program
{
    public static void Main(string[] args)
    {
        Publisher publisher = new();
        EmailAlertListener emailAlertListener = new(1);

        publisher.Subscribe(emailAlertListener);
        publisher.Notify("new data added");
    }
}