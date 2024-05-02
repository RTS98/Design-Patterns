using Devices;

class Remote(IDevice device)
{
    private readonly IDevice Device = device;

    public void TogglePower()
    {
        if (Device.IsEnabled())
        {
            Device.Enable();
        }
        else
        {
            Device.Disable();
        }
    }

    public int VolumeDown()
    {
        int currentVolume = Device.GetVolume();

        return Device.SetVolume(currentVolume - 1);
    }

    public int VolumeUp()
    {
        int currentVolume = Device.GetVolume();

        return Device.SetVolume(currentVolume + 1);
    }
    public int ChannelDown()
    {
        int currentChannel = Device.GetChannel();

        return Device.SetChannel(currentChannel - 1);
    }
    public int ChannelUp()
    {
        int currentChannel = Device.GetChannel();

        return Device.SetChannel(currentChannel + 1);
    }

}