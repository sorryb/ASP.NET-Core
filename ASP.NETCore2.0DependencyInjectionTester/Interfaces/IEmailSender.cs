using System.Threading.Tasks;

namespace DependencyInjectionTester.Interfaces
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}
