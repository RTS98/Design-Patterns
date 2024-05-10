using Components;

interface IMediator
{
    void Notify(Component sender, EventType eventType);
}

class AutheticationDialog : IMediator
{
    public void Notify(Component sender, EventType eventType)
    {
        if (eventType == EventType.Click)
        {
            Console.WriteLine("Do Something related to button");
            return;
        }

        if (eventType == EventType.Check)
        {
            Console.WriteLine("Do Something related to checkbox");
            return;
        }

        if (eventType == EventType.KeyPress)
        {
            Console.WriteLine("Do Something related to textbox");
            return;
        }
    }
}