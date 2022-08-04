using Patito.Domain;

namespace Patito.Application.Services.Abstractions
{
    public interface IExampleHelloWorldService
    {
        public Task<string> GetHelloWorldServiceExample();
    }
}