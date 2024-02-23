using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Test.Application.Dto.User;
using Test.Application.Services;
using Test.Domain.Entities;

namespace Test.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuhenController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IConfiguration _configuration;
        

        public AuhenController(IUserService userService, IConfiguration configuration)
        {
            _userService = userService;
            _configuration = configuration;
            
        }


       
        /*[HttpPost("dang-ky")]
        public IActionResult DangKy([FromBody] UserDto userDto)
        {
           

            // Kiểm tra tính hợp lệ của UserDto
            if (userDto == null || string.IsNullOrEmpty(userDto.UserName) || string.IsNullOrEmpty(userDto.Password))
            {
                return BadRequest(new { Message = "Thông tin người dùng không hợp lệ." });
            }

            // Kiểm tra xem tên tài khoản đã tồn tại chưa
            if (_userService.GetAll().Any(x => x.UserName == userDto.UserName))
            {
                return BadRequest(new { Message = "Tên tài khoản đã tồn tại." });
            }

           
            
            

            // Thêm người dùng vào cơ sở dữ liệu
            if (_userService.Add(userDto) == false)
            {
                // Lấy thông tin người dùng sau khi đã được thêm vào cơ sở dữ liệu
                var addedUser = _userService.GetAll().FirstOrDefault(x => x.UserName == userDto.UserName);
                return Ok(new { Message = "Đăng ký thành công" });
                // Trường hợp không thành công


            }
            // Đăng ký thành công, trả về thông báo
            return BadRequest("Đăng ký không thành công");
        }
        */
       



        [HttpPost("dang-nhap")]
        public IActionResult Login([FromBody] UserDto userDto)
        {
            

            if (userDto?.UserName == null || userDto?.Password == null)
            {
                return Unauthorized();
            }

         
            var secretKey = _configuration["JWT:Secret"];
            if (secretKey == null)
            {
               
                return Unauthorized();
            }

            
            var user = _userService.GetAll().Find(x => x.UserName == userDto.UserName && x.Password == userDto.Password);
            var role = _userService.GetRoleByUserName(userDto.UserName);

            if (user != null)
            {
                var tenNV = user.TenNV;
              

                var signingKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey));
            
                var signingCredential = new SigningCredentials(signingKey, SecurityAlgorithms.HmacSha256);
                
                var claims = new List<Claim>
                {
                 
                 new(ClaimTypes.NameIdentifier, userDto.UserName),
                 new(ClaimTypes.Role, role?.TenQuyen ?? "DefaultRole"),
                 new(ClaimTypes.Name, user.TenNV??"bị null"),
                };

                var token = new JwtSecurityToken
                (
                    issuer: _configuration["JWT:Issuer"],
                    audience: _configuration["JWT:Audience"],
                    expires: DateTime.Now.AddHours(1),
                    signingCredentials: signingCredential,
                    claims: claims
                );

                // Sinh ra chuỗi token với các thông số ở trên
                return Ok(new
                {
                    token = new JwtSecurityTokenHandler().WriteToken(token)
                });
            }

            return Unauthorized();
        }
    }
}
