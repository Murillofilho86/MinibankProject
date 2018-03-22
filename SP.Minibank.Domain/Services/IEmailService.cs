namespace SP.Minibank.Domain.Services
{
    public interface IEmailService
    {
        void SendEmailNotification(string to, string from, string subject, string body);
    }
}