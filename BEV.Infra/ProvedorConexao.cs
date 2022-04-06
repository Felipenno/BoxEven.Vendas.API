using BEV.Domain.Interfaces.Service;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace BEV.Infra
{
    public class ProvedorConexao : IProvedorConexao
    {
        private readonly IConfiguration _config;

        public ProvedorConexao(IConfiguration configuration)
        {
            _config = configuration;
        }

        public SqlConnection BoxEvenConexao()
        {
            return new SqlConnection(StringConexao());
        }

        public string BoxEvenMongoConexao()
        {
            return _config.GetConnectionString("mongoDB");
        }

        public string StringConexao()
        {
            return _config.GetConnectionString("DBConnection");
        }
    }
}