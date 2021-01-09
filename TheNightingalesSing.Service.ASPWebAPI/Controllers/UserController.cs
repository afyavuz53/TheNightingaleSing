using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheNightingalesSing.BLL.Abstract;
using TheNightingalesSing.Model.Entities;
using TheNightingalesSing.Service.ASPWebAPI.Models;

namespace TheNightingalesSing.Service.ASPWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        IUserBLL userBLL;
        public UserController(IUserBLL bLL)
        {
            userBLL = bLL;
        }
        public IActionResult Get()
        {
            List<UserDto> userDtos = new List<UserDto>();
            List<User> users = userBLL.GetAll().ToList(); 
            foreach (User item in users)
            {
                userDtos.Add(new UserDto()
                {
                    UserID = item.ID,
                    UserName = item.UserName,
                    EMail = item.Email,
                    Role = item.Role.ToString(),
                    IsActive = item.IsActive
                });
            }
            return Ok(userDtos);
        }
    }
}
