using System;

namespace DesignPatterns.Mediator.Example
{
    public class AuthenticationWindow
    {
        public TextBox UsernameTextBox { get; private set; } = new TextBox();
        public TextBox PasswordTextBox { get; private set; } = new TextBox();
        public CheckedBox TermOfServicesCheckBox { get; private set; } = new CheckedBox();
        private readonly Button _loginButton = new Button();

        public AuthenticationWindow()
        {
            UsernameTextBox.AddEventHandler(StateChanged);
            PasswordTextBox.AddEventHandler(StateChanged);
            TermOfServicesCheckBox.AddEventHandler(StateChanged);
        }

        private void PrintState()
        {
            Console.WriteLine($"{UsernameTextBox.Text} - {PasswordTextBox.Text} - " +
                              $"{TermOfServicesCheckBox.IsChecked} - {_loginButton.IsEnabled}");
            Console.WriteLine("--------------------------------------------------------------------");
        }

        private void StateChanged()
        {
            var isEnabled = !string.IsNullOrWhiteSpace(UsernameTextBox.Text)
                            && !string.IsNullOrWhiteSpace(PasswordTextBox.Text)
                            && TermOfServicesCheckBox.IsChecked;

            _loginButton.IsEnabled = isEnabled;

            PrintState();
        }
    }
}
