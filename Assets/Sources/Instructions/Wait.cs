using UnityEngine;

namespace Store.Client
{
    public sealed class Wait : Instruction
    {
        [SerializeField] private int _timeSec = default;

        public override async void Process()
        {
            await Awaitable.WaitForSecondsAsync(_timeSec);
            base.Complete();
        }
    }
}
