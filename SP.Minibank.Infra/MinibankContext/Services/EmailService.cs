using SP.Minibank.Domain.Services;

namespace SP.Minibank.Infra.MinibankContext.Services
{
    public class EmailService : IEmailService
    {
        public void SendEmailNotification(string to, string from, string subject, string body)
        {
            //TODO: Implementar envio de email
        }
    }
}