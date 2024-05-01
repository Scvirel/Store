using TMPro;
using UnityEngine;

namespace Store.Client
{
    public sealed class DisplayUserCoins : Instruction<ulong>
    {
        [SerializeField] private TextMeshProUGUI _coinsField = default;

        public override void Process(ulong input)
        {
            _coinsField.text = input.ToString();

            base.Complete();
        }
    }
}
