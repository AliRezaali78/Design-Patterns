namespace DesignPatterns.Proxy
{
    public class ProxyEbook : IEbook
    {
        public string FileName { get; }
        private EBook _book;

        public ProxyEbook(string fileName)
        {
            FileName = fileName;
        }
        public void Show()
        {
            _book ??= new EBook(FileName);

            _book.Show();
        }
    }
}