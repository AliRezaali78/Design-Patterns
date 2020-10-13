namespace DesignPatterns.Decorator.Example
{
    public class MainArtifact : IArtifact
    {
        private readonly IArtifact _artifact;
        private const string Icon = "[Main]";

        public MainArtifact(IArtifact artifact)
        {
            _artifact = artifact;
        }


        public string Render()
        {
            return $"{_artifact.Render()} {Icon}";
        }
    }
}