using Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Services.Domains;
using System.Linq;

namespace Host.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        readonly UserDomain domain;
        public UserController()
        {
            domain = new UserDomain();
        }
        [HttpGet]
        //returns all existed users, if !users.Any() - NotFound 
        public IActionResult Get()
        {
            try
            {
                var users = domain.Get();
                return users.Any()
                    ? new OkObjectResult(users)
                    : NotFound($"It seems,the database has no users");
            }
            catch (System.Exception)
            {
                //ToDO exCatcher
                throw;
            }
        }
        //returns user by id, if user == null - NotFound
        [HttpGet("{id}")]
        public IActionResult Get(string id)
        {
            try
            {
                User user = domain.GetUserById(id);
                return (user != null)
                    ? Ok(user)
                    : NotFound($"There is no user with id={id}");
            }
            catch (System.Exception)
            {
            }
        }
    }
}
