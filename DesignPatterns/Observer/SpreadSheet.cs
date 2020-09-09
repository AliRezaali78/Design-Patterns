using System;

namespace DesignPatterns.Observer
{
    public class SpreadSheet : IObserver
    {
        private readonly DataSource _dataSource;

        public SpreadSheet(DataSource dataSource)
        {
            _dataSource = dataSource;
            dataSource.Attach(this);
        }
        public void Update()
        {
            Console.WriteLine("Spread sheet has been updated " + _dataSource.Value);
        }
    }
}