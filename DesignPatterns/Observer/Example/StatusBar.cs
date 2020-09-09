using System;
using System.Collections;
using System.Collections.Generic;

namespace DesignPatterns.Observer.Example
{
    public class StatusBar : IObserver, IEnumerable<Stock>
    {
        private readonly HashSet<Stock> _stocks = new HashSet<Stock>();

        public void AddStock(Stock stock)
        {
            _stocks.Add(stock);
            stock.Attach(this);
        }

        public void RemoveStock(Stock stock)
        {
            _stocks.Remove(stock);
            stock.Detach(this);
        }

        public void Update()
        {
            foreach (var stock in _stocks)
                Console.WriteLine("Status Bar " + stock.Price);
        }

        public IEnumerator<Stock> GetEnumerator()
        {
            return _stocks.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}