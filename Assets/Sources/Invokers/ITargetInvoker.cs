namespace Store.Client
{
    public interface ITargetInvoker<TInput>
    {
        public void Execute(TInput input);
    }
}
