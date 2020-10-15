using System;

namespace DesignPatterns.Proxy
{
    public class LoggingEbookProxy : IEbook
    {
        private EBook _book;
        public string FileName { get; }

        public LoggingEbookProxy(string fileName)
        {
            FileName = fileName;
        }

        public void Show()
        {
            _book ??= new EBook(FileName);
            Console.WriteLine("logging...");
            _book.Show();
        }
    }
}
