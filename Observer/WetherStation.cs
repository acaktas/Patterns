using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    // Uses the Observable interface to update all Observers

    class WetherStation : IObservable
    {
        List<IObserver> observers;

        public WetherStation()
        {
            observers = new List<IObserver>();
        }
        public void Notify()
        {
            foreach (var observer in observers)
            {
                observer.Update();
            }
        }

        public void Register(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Unregister(IObserver observer)
        {
            observers.Remove(observer);
        }

        public int GetTemperature()
        {
            Random rnd = new Random();
            return rnd.Next(100);
        }
    }
}
