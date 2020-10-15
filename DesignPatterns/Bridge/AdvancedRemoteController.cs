namespace DesignPatterns.Bridge
{
    public class AdvancedRemoteController : RemoteController
    {
        public AdvancedRemoteController(IDevice device) : base(device)
        { }

        public void SetChanel(int chanel)
        {
            Device.SetChanel(chanel);
        }
    }
}