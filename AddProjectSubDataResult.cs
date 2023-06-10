namespace UnofficialUGSCLIUI
{
    public class AddProjectSubDataResult<T> where T : class
    {
        public bool Success => Data != null;
        public string ErrorReason { get; } = string.Empty;
        public T Data { get; } = null;

        public AddProjectSubDataResult(T data)
        {
            Data = data;
        }

        public AddProjectSubDataResult(string errorReason)
        {
            ErrorReason = errorReason;
        }
    }
}