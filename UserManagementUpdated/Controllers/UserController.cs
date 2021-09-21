using System;
using System.Collections.Generic;
using UserManagement.Domain;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using UserManagement.Repository;
using UserManagement.Services;

namespace UserManagement.Controllers
{
    [ApiController]
    [Route("taazaa/[controller]")]
    public class UserController : ControllerBase
    {
        IUserProfileRepository userProfileRepository;
        IUserRepository userRepository;
        public UserController(IUserProfileRepository _userProfileRepository,IUserRepository _userRepository)
        {
            userProfileRepository = _userProfileRepository;
            userRepository = _userRepository;
        }
        [HttpPost]
        [Route("CreateUser")]
        public IActionResult createAccount(UserDTO model)
        {
            User userobj = new User
            {
                UserName = model.UserName,
                Email = model.Email,
                Password = model.Password,
                AdditDate = DateTime.UtcNow,
                ModifiedDate = DateTime.UtcNow,
                IPaddress = Request.HttpContext.Connection.RemoteIpAddress.ToString(),
                userProfile = new UserProfile
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Address = model.Address,
                    AdditDate = DateTime.UtcNow,
                    ModifiedDate = DateTime.UtcNow,
                    IPaddress = Request.HttpContext.Connection.RemoteIpAddress.ToString()
                }
            };
            userRepository.InsertUser(userobj);
            return Ok("record added");
        }
    }
}