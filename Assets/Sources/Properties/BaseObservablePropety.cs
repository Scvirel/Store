using System;
using System.Collections.Generic;

namespace Store.Client
{
    public class BaseObservablePropety<Type> : IObservableProperty<Type>
    {
        private Type _value = default;
        public Type Value
        {
            get => _value;
            set
            {
                _value = value;
                NotifyObservers(value);
            }
        }

        private IList<IObserver<Type>> _observers = new List<IObserver<Type>>();

        public IDisposable Subscribe(IObserver<Type> observer)
        {
            if (!_observers.Contains(observer))
            {
                _observers.Add(observer);
            }

            return new Subscription<Type>(_observers, observer);
        }

        private void NotifyObservers(Type value)
        {
            foreach (var observer in _observers)
            {
                observer.OnNext(value);
            }
        }
    }
}
