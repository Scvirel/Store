using System;

namespace Store.Client
{
    public interface IObservableProperty<Type> : IProperty<Type>, IObservable<Type>
    {
    }
}
