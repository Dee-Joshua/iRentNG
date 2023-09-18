namespace IRentNG.Entities.Exceptions
{
    public sealed class PhotoFileUploadException : FileUploadException
    {
        public PhotoFileUploadException() : base("Failed to upload photo")
        {
        }
    }
}
