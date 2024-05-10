namespace EventListeners
{
    class LoggingListeners(int id) : EventListener(id)
    {
        public override void Update(string data) => Console.WriteLine($"Update {data} in email alert listener");
    }
}