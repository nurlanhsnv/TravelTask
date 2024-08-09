using EntitiesT.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BusinessT.Abstract;
using BusinessT.Concrete;
using DataAccessT.Concrete;

namespace TravelAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService) 
        {
            _userService = userService;
        }
         
        [HttpGet("GetAllUsers")]
        public IActionResult GetUsers()
        {
            
            var result = _userService.GetAllUsers();
            // return result.Data;
            if (result.Success) {
                return Ok(result);
            }
            else return BadRequest(result);
         }

        [HttpGet ("GetUserById")]
        public IActionResult Get(int id) 
        {
            var result = _userService.Get(id);
            if (result.Success) 
            {
                return Ok(result);
            }
            else return BadRequest(result);
        }

        [HttpPost("addUser")]
        public IActionResult Add(User user) 
        {
            var result = _userService.Add(user);
            if (result.Success) 
            {
                return Ok(result);
            }
            else return BadRequest(result);
        }
        [HttpPost("deleteUser")]
        public IActionResult Delete(int id) 
        {
            var result = _userService.Delete(id);
            if (result.Success) 
            {
                return Ok(result);
            }
            else return BadRequest(result);
        }
        [HttpPut ("updateUser")]
        public IActionResult Update(User user)
        {
            var result = _userService.Update(user);
            if (result.Success)
            {
                return Ok(result);
            }
            else return BadRequest(result);
        }
    }
}
