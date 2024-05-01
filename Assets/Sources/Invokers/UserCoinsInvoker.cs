using Zenject;

namespace Store.Client
{
    public sealed class UserCoinsInvoker : BaseObserverInvoker<ulong>
    {
        [Inject] private readonly IUserCoins m_userCoins = default;

        private void Awake()
        {
            m_userCoins.Subscribe(this);
        }
    }
}
