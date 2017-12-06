namespace Acme.Common
{
    /// <summary>
    /// Provides a success flag and message 
    /// useful as a method return type.
    /// </summary>
    public class OperationResult<T>
    {
        public OperationResult()
        {
        }

        public OperationResult(T success, string message) : this()
        {
            this.Success = success;
            this.Message = message;
        }

        //T is used to represent a generic
        public T Success { get; set; }
        public string Message { get; set; }
    }

}
