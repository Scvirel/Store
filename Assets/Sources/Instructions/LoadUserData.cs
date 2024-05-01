using Zenject;

namespace Store.Client
{
    public sealed class LoadUserData : Instruction
    {
        [Inject] private readonly ISaveLoadType _saveLoadType = default;
        [Inject] private readonly IUserCoins _userCoins = default;
        [Inject] private readonly IUserGems _userGems = default;

        [Inject] private readonly ILoadUserData _loadUserData = default;

        public override void Process()
        {
            UserDataDto data = _loadUserData.Invoke(_saveLoadType.Value);

            _userCoins.Value = data.Coins;
            _userGems.Value = data.Gems;

            base.Complete();
        }
    }
}
