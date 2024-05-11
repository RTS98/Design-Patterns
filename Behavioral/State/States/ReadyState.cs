namespace States
{
    class ReadyState(Player player) : State(player)
    {
        public override void ClickLock() => _player.ChangeState(new LockedState(_player));

        public override void ClickNext() => _player.NextSong();

        public override void ClickPlay()
        {
            _player.Play();
            _player.ChangeState(new PlayingState(_player));
        }

        public override void ClickPrevious() => _player.PreviousSong();
    }
}