using System;
using System.Collections.Generic;

namespace DesignPatterns.Mediator
{
    public abstract class UIControl
    {
        private readonly List<Action> _eventHandlers = new List<Action>();
        public void AddEventHandler(Action eventHandler)
        {
            _eventHandlers.Add(eventHandler);
        }

        protected void Notify()
        {
            foreach (var observer in _eventHandlers)
                observer();
        }
    }
}
