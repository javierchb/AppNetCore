using Dapper;
using ApiDAO.Connection;
using ApiDAO.Models;
namespace ApiDAO.DAO
{
    public class DAOUser : IDAOUser
    {
        private readonly IConnectionDB _connection;
        public DAOUser(IConnectionDB connection)
        { 
            _connection = connection;
        }
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
