using Zenject;

namespace Store.Client
{
    public sealed class UserGemsInvoker : BaseObserverInvoker<ulong>
    {
        [Inject] private readonly IUserGems m_userGems = default;

        private void Awake()
        {
            m_userGems.Subscribe(this);
        }
    }
}
