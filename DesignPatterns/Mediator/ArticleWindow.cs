using System;

namespace DesignPatterns.Mediator
{
    public class ArticleWindow
    {
        public ListBox ListBox { get; private set; } = new ListBox();
        public TextBox TextBox { get; private set; } = new TextBox();
        private readonly Button _button = new Button();

        public ArticleWindow()
        {
            ListBox.AddEventHandler(ArticleSelected);
            TextBox.AddEventHandler(TextChanged);
        }

        private void ArticleSelected()
        {
            TextBox.Text = ListBox.Selected;
        }

        private void TextChanged()
        {
            var isEmpty = string.IsNullOrWhiteSpace(TextBox.Text);
            _button.IsEnabled = !isEmpty;

            PrintState();
        }

        private void PrintState()
        {
            Console.WriteLine($"{ListBox.Selected} - {TextBox.Text} - {_button.IsEnabled}");
            Console.WriteLine("-----------------------------------------------------------------------------------");

        }
    }
}