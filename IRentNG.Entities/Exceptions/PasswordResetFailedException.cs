namespace IRentNG.Entities.Exceptions
{
    public class PasswordResetFailedException : UnauthorizedException
    {
        public PasswordResetFailedException(string message) : base(message)
        {

        }
    }
}
