namespace Store.Client
{
    public interface INoResponseCommand
    {
        void Invoke();
    }

    public interface INoResponseCommand<in TInput>
    {
        void Invoke(TInput input);
    }

    public interface INoResponseCommand<in TInput1, in TInput2>
    {
        void Invoke(TInput1 input1, TInput2 input2);
    }
}
