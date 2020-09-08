namespace DesignPatterns.Command.UndoableCommand
{
    public class BoldCommand : IUndoableCommand
    {
        private readonly Document _document;
        private readonly HistoryCommand _historyCommands;
        private string _previousContent;

        public BoldCommand(Document document, HistoryCommand historyCommands)
        {
            _document = document;
            _historyCommands = historyCommands;
        }

        public void Execute()
        {
            _previousContent = _document.Content;
            _document.MakeBold();
            _historyCommands.Push(this);
        }


        public void UnExecute()
        {
            _document.Content = _previousContent;
        }
    }
}