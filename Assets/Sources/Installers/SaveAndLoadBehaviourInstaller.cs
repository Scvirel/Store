using Zenject;

namespace Store.Client
{
    public sealed class SaveAndLoadBehaviourInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container
                .Bind<ISaveLoadType>()
                .To<SaveLoadTypeProperty>()
                .AsSingle();

            Container
                .Bind<ILoadUserData>()
                .To<LoadUserDataCommand>()
                .AsSingle();

            Container
                .Bind<ISaveUserData>()
                .To<SaveUserDataCommand>()
                .AsSingle();
        }
    }
}
