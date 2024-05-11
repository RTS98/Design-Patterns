namespace States
{
    class PlayingState(Player player) : State(player)
    {
        public override void ClickLock()
        {
            _player.ChangeState(new LockedState(_player));
        }

        public override void ClickNext()
        {
            _player.NextSong();
        }

        public override void ClickPlay()
        {
            _player.Stop();
            _player.ChangeState(new ReadyState(_player));
        }

        public override void ClickPrevious()
        {
            _player.PreviousSong();
        }
    }
}