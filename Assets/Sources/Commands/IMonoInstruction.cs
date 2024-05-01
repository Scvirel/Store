namespace Store.Client
{
    public interface IMonoInstruction : INoResponseCommand, IInstruction
    { }
    public interface IMonoInstruction<TInput> : INoResponseCommand<TInput>, IInstruction
    { }
}
