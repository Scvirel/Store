namespace Store.Client
{
    public enum ProcessingStatus : byte
    {
        None = 0,
        Success = 1,
        Running = 2,
        Failed = 3
    }
}
