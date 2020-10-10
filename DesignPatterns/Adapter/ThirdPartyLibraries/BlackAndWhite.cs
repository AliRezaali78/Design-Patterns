using System;

namespace DesignPatterns.Adapter.ThirdPartyLibraries
{
    public class BlackAndWhite
    {
        public void Init()
        {

        }

        public void Apply(Image image)
        {
            Console.WriteLine("Black and white filter applied");
        }
    }
}
