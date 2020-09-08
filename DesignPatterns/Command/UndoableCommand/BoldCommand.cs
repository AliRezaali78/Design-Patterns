namespace DesignPatterns.Command.UndoableCommand
{
    public class BoldCommand : IUndoableCommand
    {
        private readonly Document _document;
        private readonly CommandHistory _commandHistory;
        private string _previousContent;

        public BoldCommand(Document document, CommandHistory commandHistory)
        {
            _document = document;
            _commandHistory = commandHistory;
        }

        public void Execute()
        {
            _previousContent = _document.Content;
            _document.MakeBold();
            _commandHistory.Push(this);
        }


        public void UnExecute()
        {
            _document.Content = _previousContent;
        }
    }
}