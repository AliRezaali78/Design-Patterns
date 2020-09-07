using System;

namespace DesignPatterns.State.Example
{
    // state
    public interface ITravelMode
    {
        public object GetEta();

        public object GetDirection();
    }


    // state A
    public class DrivingMode : ITravelMode
    {
        public object GetEta()
        {
            Console.WriteLine("Calculating ETA");
            return 1;
        }

        public object GetDirection()
        {
            Console.WriteLine("Calculating Driving Direction");
            return 1;
        }
    }

    // state B
    public class Walking : ITravelMode
    {
        public object GetEta()
        {
            Console.WriteLine("Calculating walking eta...");
            return 5;
        }

        public object GetDirection()
        {
            Console.WriteLine("Calculating walking direction...");
            return 5;
        }
    }
}