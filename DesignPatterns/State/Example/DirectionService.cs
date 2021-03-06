﻿namespace DesignPatterns.State.Example
{
    public class DirectionService
    {
        public ITravelMode TravelMode { get; set; }

        public object GetEta()
        {
            return TravelMode.GetEta();
        }

        public object GetDirection()
        {
            return TravelMode.GetDirection();
        }
    }
}
