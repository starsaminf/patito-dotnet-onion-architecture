using Dapper;
using Microsoft.Extensions.Configuration;
using MySqlConnector;
using Patito.Infraestructure.Database.Abstractions;

namespace Patito.Infraestructure.Database
{
    public class ExampleRepository : IExampleRepository
    {
        private readonly IConfiguration _configuration;

        public ExampleRepository(IConfiguration configuration)
        {
            _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
        }

        public MySqlConnection Connection
        {
            get
            {
                return new MySqlConnection(_configuration.GetConnectionString("SqlConnection"));
            }
        }

        public async Task<string> GetHelloWorldAsync()
        {
            using (MySqlConnection connection = Connection)
            {
                var sql = "SELECT * FROM Users limit 1";
                connection.Open();
                var data = await connection.QueryFirstOrDefaultAsync<string>(sql);
                return data;
            }
        }
    }
}
