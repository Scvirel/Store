using UnityEngine;
using Zenject;

namespace Store.Client
{
    public sealed class AddCoins : Instruction
    {
        [Inject] private readonly IUserCoins _userCoins = default;

        private const int CoinsDefault = 1500;

        [SerializeField] private SaveUserData _saveUserData = default;

        public override void Process()
        {
            _userCoins.Value += CoinsDefault;

            _saveUserData.Invoke();

            base.Complete();
        }
    }
}
