using System.Threading.Tasks;

namespace DependencyInjectionTester.Interfaces
{
    public interface ISmsSender
    {
        Task SendSmsAsync(string number, string message);
    }
}
