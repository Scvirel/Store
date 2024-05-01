using UnityEngine;
using UnityEngine.SceneManagement;
using Zenject;

namespace Store.Client
{
    public sealed class LoadScene : Instruction
    {
        [Inject] private readonly ILoadScene _loadScene = default;
        
        [SerializeField] private string _sceneName = default;

        public override void Process()
        {
            _loadScene.Invoke(_sceneName, LoadSceneMode.Additive);
            
            base.Complete();
        }
    }
}
