namespace DesignPatterns.State
{
    // context
    public class Canvas
    {
        public ITool SelectedTool { get; set; }
        public void MouseDown()
        {
            SelectedTool.MouseDown();
        }

        public void MouseUp()
        {
            SelectedTool.MouseUp();
        }
    }

}
