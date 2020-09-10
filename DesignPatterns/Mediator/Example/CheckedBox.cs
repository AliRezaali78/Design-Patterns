namespace DesignPatterns.Mediator.Example
{
    public class CheckedBox : UIControl
    {
        private bool _isChecked;

        public bool IsChecked
        {
            get => _isChecked;
            set
            {
                _isChecked = value;
                Notify();
            }
        }
    }
}