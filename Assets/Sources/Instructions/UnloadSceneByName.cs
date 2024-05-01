using UnityEngine;
using Zenject;

namespace Store.Client
{
    public sealed class UnloadSceneByName : Instruction
    {
        [Inject] private readonly IUnloadSceneByName _unloadSceneByName = default;

        [SerializeField] private string _sceneName = default;

        public override void Process()
        {
            _unloadSceneByName.Invoke(_sceneName);
            base.Complete();
        }
    }
}
