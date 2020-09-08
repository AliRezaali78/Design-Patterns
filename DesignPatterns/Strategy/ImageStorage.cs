namespace DesignPatterns.Strategy
{
    public class ImageStorage
    {
        private readonly ICompressor _compressor;
        private readonly IFilter _filter;

        public ImageStorage(ICompressor compressor, IFilter filter)
        {
            _compressor = compressor;
            _filter = filter;
        }

        public void SavePhoto(string imagePath)
        {
            _compressor.Compress(imagePath);
            _filter.ApplyFilter(imagePath);
            // save photo
        }
    }
}
