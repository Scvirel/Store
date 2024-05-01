using UnityEngine;
using Zenject;

namespace Store.Client
{
    public sealed class SaveLoadTypeSetup : Instruction
    {
        [Inject] private readonly ISaveLoadType _saveLoadType = default;

        [SerializeField] private SaveLoadType _type = default;

        public override void Process()
        {
            _saveLoadType.Value = _type;

            base.Complete();
        }
    }
}
