using System;

namespace Store.Client
{
    public abstract class BaseObserverInvoker<Type> : BaseTargetInvoker<Type>, IObserverInvoker<Type>
    {
        public virtual void OnCompleted()
        {
            Console.WriteLine($"{nameof(BaseObserverInvoker<Type>)} has stopped receiving data");
        }

        public virtual void OnError(Exception error)
        {
            Console.WriteLine($"{nameof(BaseObserverInvoker<Type>)} has received an error: {error.Message}");
        }

        public virtual void OnNext(Type value)
        {
            base.Execute(value);
        }
    }
}
