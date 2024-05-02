using Devices;

class Program
{
    public static void Main(string[] args)
    {
        Remote remote = new(new Radio());

        remote.TogglePower();
        remote.VolumeUp();
        remote.VolumeUp();
        remote.ChannelUp();
        remote.ChannelUp();
        remote.TogglePower();
    }
}