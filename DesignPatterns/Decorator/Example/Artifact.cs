namespace DesignPatterns.Decorator.Example
{
    public class Artifact : IArtifact
    {
        private readonly string _name;

        public Artifact(string name)
        {
            _name = name;
        }

        public string Render()
        {
            return _name;
        }
    }
}