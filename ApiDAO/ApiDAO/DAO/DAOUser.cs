using Dapper;
using ApiDAO.Connection;
using ApiDAO.Models;
namespace ApiDAO.DAO
{
    /// <summary>
    /// Class DAOUser implement IDAOUser.
    /// </summary>
    public class DAOUser : IDAOUser
    {
        private readonly IConnectionDB _connection;
        /// <summary>
        /// Constructor DAOUser.
        /// </summary>
        /// <param name="connection">Injection dependency IConnectionDB.</param>
        public DAOUser(IConnectionDB connection)
        { 
            _connection = connection;
        }
        /// <summary>
        /// Get all users.
        /// </summary>
        /// <returns></returns>
        public List<User> GetUsers() 
        {
            List<User> Response = new List<User>();
            using (var connection = _connection.GetConnection)
            {
                var Query = "SELECT * FROM tg_user";
                var ResultQuery = connection.Query<User>(Query, commandType: System.Data.CommandType.Text);
                Response = ResultQuery.ToList();            
            }
            return Response;
        }
    }
}
