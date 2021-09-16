using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc;
using UserManagementService.Service;
using UserManagementService.Models;

namespace UserManagementService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        IUserRepository _iuserrepository;
        public UserController(IUserRepository iuserrepository)
        {
            _iuserrepository = iuserrepository;
        }
        [HttpPost]
        //[Route("CreateUser")]
        public IActionResult PostUsers(User user)
        {
            int res = _iuserrepository.AddUser(user);
            if(res!=0)
            {
                return Ok("save");
            }
            return Forbid();
        }
        [HttpGet("{id}")]
        //[Route("getUsers")]
        public IActionResult Get(int id)
        {
            var user = _iuserrepository.SearchUser(id);
            if(user==null)
            {
                return NotFound();
            }
            return Ok(user);
        }
        [HttpPut("{id}")]
        //[Route("updateuser")]
        public IActionResult updateuser(int id, User user)
        {
            int res = _iuserrepository.UpdateUser(id,user);
            if(res!=0)
            {
                return Ok(res);
            }
            return NotFound();
        }
        [HttpDelete]
        //[Route("Delete")]
        public IActionResult DeleteUser(int id)
        {
            int res = _iuserrepository.Deleteuser(id);
            if(res!=0)
            {
                return Ok("delete");
            }
            return Forbid();
        }
        [HttpGet]
        //[Route("UserList")]
        public IEnumerable<User> GetUsers()
        {
           var user=_iuserrepository.GetUsers();
           return user;
        }
    }
}