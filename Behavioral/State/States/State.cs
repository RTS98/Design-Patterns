namespace States
{
    abstract class State(Player player)
    {
        protected readonly Player _player = player;

        abstract public void ClickLock();
        abstract public void ClickPlay();
        abstract public void ClickNext();
        abstract public void ClickPrevious();
    }
}