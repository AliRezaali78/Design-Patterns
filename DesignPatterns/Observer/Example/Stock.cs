namespace DesignPatterns.Observer.Example
{
    public class Stock : Subject
    {
        private double _price;
        public double Price
        {
            get => _price;
            set
            {
                _price = value;
                Notify();
            }
        }
    }
}
