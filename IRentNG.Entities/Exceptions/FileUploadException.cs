namespace IRentNG.Entities.Exceptions
{
    public abstract class FileUploadException : Exception
    {
        protected FileUploadException(string message) : base(message)
        {
        }
    }
}
