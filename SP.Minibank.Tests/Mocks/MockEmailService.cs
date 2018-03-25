using SP.Minibank.Domain.Services;

namespace SP.Minibank.Tests.Mocks
{
    public class MockEmailService : IEmailService
    {
        public void SendEmailNotification(string to, string from, string subject, string body)
        {
           
        }
    }
}