namespace DesignPatterns.Command.UndoableCommand
{
    public class UndoCommand : ICommand
    {
        private readonly HistoryCommand _history;

        public UndoCommand(HistoryCommand history)
        {
            _history = history;
        }

        public void Execute()
        {
            if (_history.Size > 0)
                _history.Pop().UnExecute();
        }
    }
}