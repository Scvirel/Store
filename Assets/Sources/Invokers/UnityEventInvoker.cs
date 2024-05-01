using UnityEngine.Events;

namespace Store.Client
{
    public abstract class UnityEventInvoker : BaseInvoker
    {
        protected abstract UnityEvent MainEvent { get; }

        protected virtual void Awake()
        {
            MainEvent.AddListener(Process);
        }
        protected virtual void OnDestroy()
        {
            MainEvent.RemoveListener(Process);
        }

        private void Process()
        {
            base.Execute();
        }
    }
}
