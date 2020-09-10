namespace DesignPatterns.Mediator
{
    public class ListBox : UIControl
    {
        private string _selected;
        public string Selected
        {
            get => _selected;
            set
            {
                _selected = value;
                Notify();
            }
        }
    }

    public class Button : UIControl
    {
        private bool _isEnabled;

        public bool IsEnabled
        {
            get => _isEnabled;
            set
            {
                _isEnabled = value;
                Notify();
            }
        }
    }
}