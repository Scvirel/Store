using UnityEngine.SceneManagement;
using Zenject;

namespace Store.Client
{
    public sealed class LoadDefaultScenes : Instruction
    {
        [Inject] private readonly ILoadScene _loadScene = default;

        public override void Process()
        {
            _loadScene.Invoke(GameScenes.MainCamera, LoadSceneMode.Additive);
            _loadScene.Invoke(GameScenes.EventSystem, LoadSceneMode.Additive);

            base.Complete();
        }
    }

}
