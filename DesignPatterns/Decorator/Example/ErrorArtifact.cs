namespace DesignPatterns.Decorator.Example
{
    public class ErrorArtifact : IArtifact
    {

        private readonly IArtifact _artifact;
        private const string Icon = "[Error]";

        public ErrorArtifact(IArtifact artifact)
        {
            _artifact = artifact;
        }


        public string Render()
        {
            return $"{_artifact.Render()} {Icon}";
        }
    }
}