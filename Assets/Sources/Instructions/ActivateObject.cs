using UnityEngine;

namespace Store.Client
{
    public sealed class ActivateObject : Instruction
    {
        [SerializeField] private GameObject _object = default;

        public override void Process()
        {
            _object.SetActive(true);
            base.Complete();
        }
    }
}
