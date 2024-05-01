namespace Store.Client
{
    public interface IInstruction
    {
        ProcessingStatus Status { get; }
        void Complete();
    }
}
