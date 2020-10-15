namespace DesignPatterns.Bridge
{
    public class RemoteController
    {
        protected readonly IDevice Device;

        public RemoteController(IDevice device)
        {
            Device = device;
        }

        public void TurnOn()
        {
            Device.TurnOn();
        }

        public void TurnOff()
        {
            Device.TurnOff();
        }
    }
}
