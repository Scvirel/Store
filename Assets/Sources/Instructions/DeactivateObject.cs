using UnityEngine;

namespace Store.Client
{
    public sealed class DeactivateObject : Instruction
    {
        [SerializeField] private GameObject _object = default;

        public override void Process()
        {
            _object.SetActive(false);
            base.Complete();
        }
    }
}
