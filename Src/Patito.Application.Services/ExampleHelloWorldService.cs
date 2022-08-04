using Patito.Application.Services.Abstractions;
using Patito.Infraestructure.Database.Abstractions;
namespace Patito.Application.Services
{
    public class ExampleHelloWorldService : IExampleHelloWorldService
    {
        private readonly IExampleRepository _exampleRepository;

        public ExampleHelloWorldService(IExampleRepository exampleRepository)
        {
            _exampleRepository = exampleRepository ?? throw new ArgumentNullException(nameof(exampleRepository));
        }

        public async Task<string> GetHelloWorldServiceExample()
        {
            return await _exampleRepository.GetHelloWorldAsync();
        }
    }
}