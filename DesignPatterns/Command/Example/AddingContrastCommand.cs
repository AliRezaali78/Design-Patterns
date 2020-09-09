using DesignPatterns.Command.UndoableCommand;

namespace DesignPatterns.Command.Example
{
    public class AddingContrastCommand : AbstractUndoableCommand
    {
        private readonly float _contrast;
        private readonly float _previousContrast;

        public AddingContrastCommand(float contrast, VideoEditor videoEditor, CommandHistory commandHistory)
        : base(videoEditor, commandHistory)
        {
            _contrast = contrast;
            _previousContrast = videoEditor.Contrast;
        }


        protected override void DoExecute()
        {
            VideoEditor.Contrast = _contrast;
        }

        protected override void DoUnExecute()
        {
            VideoEditor.Contrast = _previousContrast;
        }
    }
}