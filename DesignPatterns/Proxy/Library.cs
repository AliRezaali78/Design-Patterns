using System.Collections.Generic;

namespace DesignPatterns.Proxy
{
    public class Library
    {
        private readonly Dictionary<string, IEbook> _eBooks = new Dictionary<string, IEbook>();

        public void AddEbook(IEbook ebook)
        {
            _eBooks.TryAdd(ebook.FileName, ebook);
        }

        public void OpenBook(string fileName)
        {
            if (_eBooks.ContainsKey(fileName))
                _eBooks[fileName].Show();
        }
    }
}