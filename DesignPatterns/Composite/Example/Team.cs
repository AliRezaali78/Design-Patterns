using System.Collections.Generic;

namespace DesignPatterns.Composite.Example
{
    public class Team : IUnit
    {
        public List<IUnit> Units { get; set; } = new List<IUnit>();
        public void Deploy()
        {
            foreach (var unit in Units)
                unit.Deploy();
        }
    }
}
