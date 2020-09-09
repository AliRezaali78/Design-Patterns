using DesignPatterns.Command.UndoableCommand;

namespace DesignPatterns.Command.Example
{
    public class AddingLabelCommand : AbstractUndoableCommand
    {
        private readonly string _text;
        private readonly string _previousLabel;

        public AddingLabelCommand(string text, VideoEditor videoEditor, CommandHistory commandHistory)
         : base(videoEditor, commandHistory)
        {
            _text = text;
            _previousLabel = VideoEditor.Text;
        }


        protected override void DoExecute()
        {
            VideoEditor.Text = _text;
        }

        protected override void DoUnExecute()
        {
            VideoEditor.Text = _previousLabel;
        }
    }
}