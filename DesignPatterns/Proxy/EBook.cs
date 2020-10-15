using System;

namespace DesignPatterns.Proxy
{
    public class EBook : IEbook
    {
        public string FileName { get; }

        public EBook(string fileName)
        {
            FileName = fileName;
            Load();
        }

        public void Load()
        {
            Console.WriteLine("Loading ebook " + FileName);
        }

        public void Show()
        {
            Console.WriteLine("Showing ebook " + FileName);
        }

    }
}