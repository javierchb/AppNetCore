using System.Data;
using Microsoft.Data.SqlClient;
namespace ApiDAO.Connection
{
    public class ConnectionDB : IConnectionDB
    {
        private readonly IConfiguration _configuration;
        public ConnectionDB(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IDbConnection GetConnection
        {
            get
            {
                var sqlConnection = new SqlConnection();
                if (sqlConnection != null)
                {
                    sqlConnection.ConnectionString = _configuration["ConnectionString"];
                    sqlConnection.Open();
                    return sqlConnection;
                }
                return null;
            }
        }
    }
}
