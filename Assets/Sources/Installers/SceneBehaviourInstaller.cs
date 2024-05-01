using Zenject;

namespace Store.Client
{
    public sealed class SceneBehaviourInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container
                .Bind<ILoadScene>()
                .To<LoadSceneCommand>()
                .AsSingle();

            Container
                .Bind<IUnloadScene>()
                .To<UnloadSceneCommand>()
                .AsSingle();

            Container
                .Bind<IUnloadSceneByName>()
                .To<UnloadSceneByNameCommand>()
                .AsSingle();

            Container
                .Bind<IActivateScene>()
                .To<ActivateSceneCommand>()
                .AsSingle();
        }
    }
}
