using System.Data;
using Microsoft.Data.SqlClient;
namespace ApiDAO.Connection
{
    /// <summary>
    /// Class ConnectionDB implement IConnectionDB.
    /// </summary>
    public class ConnectionDB : IConnectionDB
    {
        private readonly IConfiguration _configuration;
        /// <summary>
        /// Constructor ConnectionDB.
        /// </summary>
        /// <param name="configuration"></param>
        public ConnectionDB(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        /// <summary>
        /// Get DB Connection.
        /// </summary>
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
