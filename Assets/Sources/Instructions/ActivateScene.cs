using UnityEngine;
using Zenject;

namespace Store.Client
{
    public sealed class ActivateScene : Instruction
    {
        [Inject] private readonly IActivateScene _activateScene = default;

        [SerializeField] private string _sceneName = default;

        public override void Process()
        {
            _activateScene.Invoke(_sceneName);

            base.Complete();
        }
    }
}
