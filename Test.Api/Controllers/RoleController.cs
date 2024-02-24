using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Test.Application.Dto.User;
using Test.Application.Services;

namespace Test.Api.Controllers
{
    [Authorize(Roles = "Admin,NVSanPham,NVKho,NVNhanSu")]

    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly IRoleService _roleService;
        public RoleController(IRoleService roleService)
        {
            _roleService = roleService;
        }
        [HttpGet]
        public IActionResult GetRoles()
        {

            return Ok(_roleService.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetRole(Guid id)
        {
            var nccs = _roleService.Get(id);
            if (nccs == null)
            {
                return NotFound();//trả về mã 404
            }
            return Ok(nccs);//trả về mã 200 cho product
        }

        [HttpPost]
        public IActionResult AddRole(RoleDto roleDto)
        {
            roleDto.RoleId = Guid.NewGuid();
            if (_roleService.Add(roleDto) == false)
            {

                return CreatedAtAction(nameof(GetRole), new { id = roleDto.RoleId }, roleDto);

            }


            return Conflict("Role này đã tồn tại");
        }


        [HttpPut("{id}")]
        public IActionResult UpdateRole(RoleDto roleDto)
        {
            if (_roleService.Update(roleDto))
            {
                return NoContent();
            }
            return NotFound();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteRole(Guid id)
        {
            if (_roleService.Delete(id))
            {
                return NoContent();
            }
            return NotFound("Không thể xóa vì role không tồn tại");
        }
    }
}
