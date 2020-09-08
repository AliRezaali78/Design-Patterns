namespace DesignPatterns.Command
{
    public class AddCustomerCommand : ICommand
    {
        private readonly CustomerManager _manager;

        public AddCustomerCommand(CustomerManager manager)
        {
            _manager = manager;
        }
        public void Execute()
        {
            _manager.AddCustomer();
        }
    }
}