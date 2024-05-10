using EventListeners;

class Publisher
{
    private EventListener[] _listeners = [];

    public void Subscribe(EventListener listener) => _listeners = [.. _listeners, listener];

    public void Unsubscribe(EventListener listener) => _listeners = _listeners.Where((EventListener element) => element.Id == listener.Id).ToArray();

    public void Notify(string data)
    {
        foreach (EventListener listener in _listeners)
        {
            listener.Update(data);
        }
    }
}