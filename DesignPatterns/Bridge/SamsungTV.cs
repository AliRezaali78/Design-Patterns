using System;

namespace DesignPatterns.Bridge
{
    public class SamsungTV : IDevice
    {
        public void TurnOn()
        {
            Console.WriteLine("Samsung : Turning ON");
        }

        public void TurnOff()
        {
            Console.WriteLine("Samsung : Turning Off");
        }

        public void SetChanel(int chanel)
        {
            Console.WriteLine("Samsung : Set Chanel");
        }
    }
}