using Zenject;

namespace Store.Client
{
    public sealed class SaveUserData : Instruction
    {
        [Inject] private readonly ISaveLoadType _saveLoadType = default;
        [Inject] private readonly IUserCoins _userCoins = default;
        [Inject] private readonly IUserGems _userGems = default;

        [Inject] private readonly ISaveUserData _saveUserData = default;

        public override void Process()
        {
            _saveUserData.Invoke(
                _saveLoadType.Value,
                new UserDataDto(
                    _userCoins.Value,
                    _userGems.Value
                    )
                );

            base.Complete();
        }
    }
}
