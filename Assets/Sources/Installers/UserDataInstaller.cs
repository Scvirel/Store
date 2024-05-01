using Zenject;

namespace Store.Client
{
    public sealed class UserDataInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container
                .Bind<IUserCoins>()
                .To<UserCoinsProperty>()
                .AsSingle();

            Container
                .Bind<IUserGems>()
                .To<UserGemsProperty>()
                .AsSingle();
        }
    }
}
