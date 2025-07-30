using DomainClass.Models;
using Logics.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Contracts;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IUserService _userService;
        public LoginController(IUserService userService ) 
        {
            _userService = userService;
        }
        [HttpGet]
        public async Task<ActionResult<List<UserResponse>>> GetUser()
        {
            var users = await _userService.GetUsers();
            var result = users.Select(u => new UserResponse(u.Id, u.Name, u.RoleOfUser, u.HashPassword));
            return Ok(result);
        }
        [HttpPost]
        public async Task<ActionResult<Guid>> PostUser([FromBody]UserRequest request)
        {
            var (user, error) = User_.CreateUser(Guid.NewGuid(), request.Name, request.role, request.password);

            if (!string.IsNullOrEmpty(error))
            {
                return BadRequest(error);
            }
            return await _userService.CreateUser(user);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Guid>> DeleteUser(Guid id)
        {
            return Ok(await _userService.DeleteUser(id));
        }
    }
}
