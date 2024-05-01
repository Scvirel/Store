using System;

namespace Store.Client
{
    [Serializable]
    public sealed class UserDataDto
    {
        public ulong Coins = default;
        public ulong Gems = default;

        public UserDataDto(ulong coins, ulong gems)
        {
            Coins = coins;
            Gems = gems;
        }
    }
}
