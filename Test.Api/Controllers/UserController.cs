using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Test.Application.Dto.User;
using Test.Application.Services;

namespace Test.Api.Controllers
{
    [Authorize(Roles = "Admin")]
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        

        public UserController(IUserService userService)
        {
            _userService = userService;
            
        }
        [HttpPost]
        public IActionResult AddUser(UserDto userDto)
        {
            userDto.UserId = Guid.NewGuid();

            var existingUser = _userService.GetAll().FirstOrDefault(x => x.UserName == userDto.UserName);

            if (existingUser != null)
            {
                
                return BadRequest(new { Message = "Tài khoản đã tồn tại." });
            }

            
            if (_userService.Add(userDto) == false)
            {
                
                return CreatedAtAction("AddUser", new { id = userDto.UserId }, new { Message = "Tạo tài khoản thành công", CreatedUserId = userDto.UserId });
            }

            // Trường hợp không thành công
            return BadRequest(new { Message = "Không thể tạo tài khoản." });
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_userService.GetAll());
        }
        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            var user = _userService.Get(id);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }

        [HttpPut("{id}")]
        public IActionResult Put(UserDto user)
        {
            if (_userService.Update(user))
            {
                return NoContent();
            }
            return NotFound();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            if (_userService.Delete(id))
            {
                return NoContent();
            }
            return NotFound("Không thể xóa vì user này không tồn tại");
        }
    }
}

