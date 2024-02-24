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
    public class DMSanPhamController : ControllerBase
    {
        private readonly IDMSanPhamService _dmspService;
        public DMSanPhamController(IDMSanPhamService dmspService)
        {
            _dmspService = dmspService;
        }
        [HttpGet]
        public IActionResult GetDMSPs()
        {

            return Ok(_dmspService.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetDMSP(Guid id)
        {
            var dmsp = _dmspService.Get(id);
            if (dmsp == null)
            {
                return NotFound();//trả về mã 404
            }
            return Ok(dmsp);//trả về mã 200 cho product
        }

        [HttpPost]
        public IActionResult AddDMSP(DMSanPhamDto dmspDto)
        {
            dmspDto.IdDMSanPham = Guid.NewGuid();
            if (_dmspService.Add(dmspDto) == false)
            {

                return CreatedAtAction(nameof(GetDMSP), new { id = dmspDto.IdDMSanPham }, dmspDto);

            }


            return Conflict("DM Sản phẩm này đã tồn tại");
        }


        [HttpPut("{id}")]
        public IActionResult UpdateDMSP(DMSanPhamDto dmspDto)
        {
            if (_dmspService.Update(dmspDto))
            {
                return NoContent();
            }
            return NotFound();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteDMSP(Guid id)
        {
            if (_dmspService.Delete(id))
            {
                return NoContent();
            }
            return NotFound("Không thể xóa vì dm sản phẩm không tồn tại");
        }
    }
}
