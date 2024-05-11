using States;

class Player
{
    private State _state;
    private bool _isPlaying = false;

    public Player()
    {
        _state = new ReadyState(this);
    }

    public State CurrentState() => _state;

    public void ChangeState(State state) => _state = state;

    public void ClickLock() => _state.ClickLock();

    public void ClickPlay() => _state.ClickPlay();

    public void ClickPrevious() => _state.ClickPrevious();

    public bool IsPlaying() => _isPlaying;

    public void NextSong()
    {
        // play next song
    }

    public void Play()
    {
        // start player
    }

    public void PreviousSong()
    {
        // play previous song
    }

    public void Stop()
    {
        // stop player;
    }
}