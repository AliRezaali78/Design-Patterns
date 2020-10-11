using System;

namespace DesignPatterns.Composite.Example
{
    public class HumanResource : IUnit
    {
        public void Deploy()
        {
            Console.WriteLine("Deploying Human Resource");
        }
    }
}