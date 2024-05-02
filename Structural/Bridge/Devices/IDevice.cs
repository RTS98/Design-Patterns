namespace Devices
{
    interface IDevice
    {
        bool IsEnabled();
        void Enable();
        void Disable();
        int GetVolume();
        int GetChannel();
        int SetVolume(int volume);
        int SetChannel(int channel);
    }
}