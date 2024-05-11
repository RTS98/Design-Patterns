namespace States
{
    class LockedState(Player player) : State(player)
    {
        public override void ClickLock()
        {
            if (_player.IsPlaying())
            {
                _player.ChangeState(new PlayingState(_player));
            }
            else
            {
                _player.ChangeState(new ReadyState(_player));
            }
        }

        public override void ClickNext() { }

        public override void ClickPlay() { }

        public override void ClickPrevious() { }
    }
}
