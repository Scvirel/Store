namespace Store.Client
{
    public sealed class SaveLoadTypeProperty : ISaveLoadType
    {
        private SaveLoadType _value = default;
        public SaveLoadType Value
        {
            get => _value;
            set => _value = value;
        }
    }
}
