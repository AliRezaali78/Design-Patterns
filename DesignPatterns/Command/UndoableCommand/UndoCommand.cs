namespace DesignPatterns.Command.UndoableCommand
{
    public class UndoCommand : ICommand
    {
        private readonly CommandHistory _commandHistory;

        public UndoCommand(CommandHistory commandHistory)
        {
            _commandHistory = commandHistory;
        }

        public void Execute()
        {
            if (_commandHistory.Size > 0)
                _commandHistory.Pop().UnExecute();
        }
    }
}