using System;

namespace DesignPatterns.Observer
{
    public class Chart : IObserver
    {
        private readonly DataSource _dataSource;

        public Chart(DataSource dataSource)
        {
            _dataSource = dataSource;
            dataSource.Attach(this);
        }

        public void Update()
        {
            Console.WriteLine("Chart has been updated " + _dataSource.Value);
        }
    }
}