namespace Patito.Infraestructure.Database.Abstractions
{
    public interface IExampleRepository
    {
        public Task<string> GetHelloWorldAsync();
    }
}