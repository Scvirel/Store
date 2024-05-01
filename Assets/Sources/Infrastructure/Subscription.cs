using System;
using System.Collections.Generic;

namespace Store.Client
{
    public class Subscription<T> : IDisposable
    {
        private IList<IObserver<T>> _observers = default;
        private IObserver<T> _observer = default;

        public Subscription(IList<IObserver<T>> observers, IObserver<T> observer)
        {
            _observers = observers;
            _observer = observer;
        }

        public void Dispose()
        {
            if (_observer != null && _observers.Contains(_observer))
            {
                _observers.Remove(_observer);
            }
        }
    }
}
