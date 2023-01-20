using ApiDAO.Models;
namespace ApiDAO.DAO
{
    /// <summary>
    /// Interface IDAOUser.
    /// </summary>
    public interface IDAOUser
    {
        public List<User> GetUsers();
    }
}
