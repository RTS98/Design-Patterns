namespace Devices
{
    class TV : IDevice
    {
        private int Channel = 0;
        private int Volume = 0;
        private bool Enabled = false;

        public void Disable() => Enabled = !Enabled;

        public void Enable() => Enabled = !Enabled;

        public int GetChannel() => Channel;

        public int GetVolume() => Volume;

        public bool IsEnabled() => Enabled;

        public int SetChannel(int channel) => Channel = channel;

        public int SetVolume(int volume) => Volume = volume;
    }
}