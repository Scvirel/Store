using Zenject;

namespace Store.Client
{
    public sealed class UnloadCurrentScene : Instruction
    {
        [Inject] private readonly IUnloadScene _unloadScene = default;

        public override void Process()
        {
            _unloadScene.Invoke(gameObject.scene);
            base.Complete();
        }
    }
}
