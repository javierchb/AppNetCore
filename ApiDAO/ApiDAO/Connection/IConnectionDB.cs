using System.Data;
namespace ApiDAO.Connection
{
    public interface IConnectionDB
    {
        IDbConnection GetConnection { get; }
    }
}
