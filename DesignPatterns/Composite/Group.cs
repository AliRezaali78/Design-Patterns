using System.Collections.Generic;

namespace DesignPatterns.Composite
{
    public class Group : IComponent
    {
        public List<IComponent> Components { get; set; } = new List<IComponent>();
        public void Render()
        {
            foreach (var component in Components)
                component.Render();
        }

        public void Resize()
        {
            foreach (var component in Components)
                component.Resize();
        }
    }
}