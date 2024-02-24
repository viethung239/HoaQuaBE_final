using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Test.Application.Dto;
using Test.Application.Services;

namespace Test.Api.Controllers
{
    [Authorize(Roles = "Admin,NVSanPham,NVKho,NVNhanSu")]

    [Route("api/[controller]")]
    [ApiController]
    public class NhaCungCapController : ControllerBase
    {
        private readonly INhaCungCapService _nccService;
        public NhaCungCapController(INhaCungCapService nccService)
        {
            _nccService = nccService;
        }
        [HttpGet]
        public IActionResult GetNCCs()
        {

            return Ok(_nccService.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetNCC(Guid id)
        {
            var dmsp = _nccService.Get(id);
            if (dmsp == null)
            {
                return NotFound();//trả về mã 404
            }
            return Ok(dmsp);//trả về mã 200 cho product
        }

        [HttpPost]
        public IActionResult AddNCC(NhaCungCapDto nccDto)
        {
            nccDto.IdNhaCungCap = Guid.NewGuid();
            if (_nccService.Add(nccDto) == false)
            {

                return CreatedAtAction(nameof(GetNCC), new { id = nccDto.IdNhaCungCap }, nccDto);

            }


            return Conflict("ncc này đã tồn tại");
        }


        [HttpPut("{id}")]
        public IActionResult UpdateNCC(NhaCungCapDto nccDto)
        {
            if (_nccService.Update(nccDto))
            {
                return NoContent();
            }
            return NotFound();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteNCC(Guid id)
        {
            if (_nccService.Delete(id))
            {
                return NoContent();
            }
            return NotFound("Không thể xóa vì ncc không tồn tại");
        }
    }
}
