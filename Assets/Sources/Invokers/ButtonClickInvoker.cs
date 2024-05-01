using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Store.Client
{
    public sealed class ButtonClickInvoker : UnityEventInvoker
    {
        [SerializeField] private Button _button = default;

        protected override UnityEvent MainEvent => _button.onClick;
    }
}
