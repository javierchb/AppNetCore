using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ApiDAO.Models;
using ApiDAO.DAO;

namespace ApiDAO.Controllers
{
    /// <summary>
    /// UserController.
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IDAOUser _daoUser;
        /// <summary>
        /// Constructor UserController.
        /// </summary>
        /// <param name="daoUser">Injection dependency IDAOUser.</param>
        public UserController(IDAOUser daoUser)
        { 
            _daoUser = daoUser;
        }
        /// <summary>
        /// Get all users.
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetUsers")]
        public List<User> GetUsers()
        { 
            List<User> Response = new List<User>();
            Response = _daoUser.GetUsers();
            return Response;
        }
    }
}
