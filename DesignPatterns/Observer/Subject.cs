using System.Collections.Generic;

namespace DesignPatterns.Observer
{
    // Observable
    public abstract class Subject
    {
        protected readonly ISet<IObserver> Observers = new HashSet<IObserver>();

        public void Attach(IObserver observer)
        {
            Observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            Observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in Observers)
                observer.Update();
        }
    }
}