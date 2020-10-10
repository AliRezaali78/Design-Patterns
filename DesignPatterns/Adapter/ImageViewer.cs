namespace DesignPatterns.Adapter
{
    public class ImageViewer
    {
        private readonly Image _image;

        public ImageViewer(Image image)
        {
            _image = image;
        }

        public void ApplyFilter(IFilter filter)
        {
            filter.Apply(_image);
        }
    }
}
