namespace IRentNG.Service.Contracts
{
    public interface IEmailService
    {
        void SendEmail(string toAddress, string subject, string body);
    }
}
