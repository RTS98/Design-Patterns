class Originator
{
    private int _state;

    public class Memento(int state)
    {
        private readonly int _state = state;

        public int State => _state;
    }

    public Memento Save() => new(_state);

    public void Restore(Memento memento) => _state = memento.State;
}