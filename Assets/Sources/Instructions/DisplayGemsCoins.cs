using TMPro;
using UnityEngine;

namespace Store.Client
{
    public sealed class DisplayUserGems : Instruction<ulong>
    {
        [SerializeField] private TextMeshProUGUI _gemsField = default;

        public override void Process(ulong input)
        {
            _gemsField.text = input.ToString();

            base.Complete();
        }
    }
}
