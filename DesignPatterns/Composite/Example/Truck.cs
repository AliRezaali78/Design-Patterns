using System;

namespace DesignPatterns.Composite.Example
{
    public class Truck : IUnit
    {
        public void Deploy()
        {
            Console.WriteLine("Deploying Truck");
        }
    }
}