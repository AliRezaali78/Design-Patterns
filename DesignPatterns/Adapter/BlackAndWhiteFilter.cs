using DesignPatterns.Adapter.ThirdPartyLibraries;

namespace DesignPatterns.Adapter
{
    public class BlackAndWhiteFilter : IFilter
    {
        private readonly BlackAndWhite _blackAndWhite;

        public BlackAndWhiteFilter(BlackAndWhite blackAndWhite)
        {
            _blackAndWhite = blackAndWhite;
            _blackAndWhite.Init();
        }

        public void Apply(Image image)
        {
            _blackAndWhite.Apply(image);
        }
    }
}
