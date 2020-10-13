using System;

namespace DesignPatterns.Decorator.Example
{
    public class VSEditor
    {
        public void OpenProject(string path)
        {
            IArtifact[] artifacts =
            {
                new Artifact("Main"),
                new Artifact("Demo"),
                new Artifact("Pagination.ts"),
                new Artifact("Table.ts"),
            };

            artifacts[0] = new ErrorArtifact(new MainArtifact(artifacts[0]));
            artifacts[2] = new ErrorArtifact(artifacts[2]);

            foreach (var artifact in artifacts)
                Console.WriteLine(artifact.Render());
        }
    }
}