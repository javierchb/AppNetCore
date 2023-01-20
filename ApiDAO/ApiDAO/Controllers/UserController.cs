using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ApiDAO.Models;
using ApiDAO.DAO;

namespace ApiDAO.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IDAOUser _daoUser;
        public UserController(IDAOUser daoUser)
        { 
            _daoUser = daoUser;
        }
        [HttpGet("GetUsers")]
        public List<User> GetUsers()
        { 
            List<User> Response = new List<User>();
            Response = _daoUser.GetUsers();
            return Response;
        }
    }
}
