using System.Data;
namespace ApiDAO.Connection
{
    /// <summary>
    /// Interface IConnectionDb.
    /// </summary>
    public interface IConnectionDB
    {
        IDbConnection GetConnection { get; }
    }
}
