using static Originator;

class CareTaker(Originator originator)
{
    private readonly Originator _originator = originator;

    private Memento[] _history = [];

    public void PerformAction()
    {
        Memento memento = _originator.Save();

        _history = [.. _history, memento];
    }

    public void Undo()
    {
        Memento memento = _history.Last();

        _originator.Restore(memento);
    }
}