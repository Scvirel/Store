namespace Store.Client
{
    public interface ICommand
    {
        void Invoke();
    }

    public interface ICommand<in TInput, out TOutput>
    {
        TOutput Invoke(TInput input);
    }
}
