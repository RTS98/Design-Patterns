namespace EventListeners
{
    abstract class EventListener(int id)
    {
        private int _id = id;

        public int Id => _id;
        
        abstract public void Update(string data);
    }
}