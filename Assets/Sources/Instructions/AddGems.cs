using UnityEngine;
using Zenject;

namespace Store.Client
{
    public sealed class AddGems : Instruction
    {
        [Inject] private readonly IUserGems _userGems = default;

        private const int GemsDefault = 40;

        [SerializeField] private SaveUserData _saveUserData = default;

        public override void Process()
        {
            _userGems.Value += GemsDefault;

            _saveUserData.Invoke();

            base.Complete();
        }
    }
}
