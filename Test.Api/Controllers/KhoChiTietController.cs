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
    public class KhoChiTietController : ControllerBase
    {
        private readonly IKhoChiTietService _khoctService;
        public KhoChiTietController(IKhoChiTietService khoctService)
        {
            _khoctService = khoctService;
        }
        [HttpGet]
        public IActionResult GetKhocts()
        {

            return Ok(_khoctService.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetKhoct(Guid id)
        {
            var dmsp = _khoctService.Get(id);
            if (dmsp == null)
            {
                return NotFound();//trả về mã 404
            }
            return Ok(dmsp);//trả về mã 200 cho product
        }

        [HttpPost]
        public IActionResult AddKhoct(KhoChiTietDto khoctDto)
        {
            khoctDto.IdKhoChiTiet = Guid.NewGuid();
            if (_khoctService.Add(khoctDto) == false)
            {

                return CreatedAtAction(nameof(GetKhoct), new { id = khoctDto.IdKhoChiTiet }, khoctDto);

            }


            return Conflict("Kho chi tiet này đã tồn tại");
        }


        [HttpPut("{id}")]
        public IActionResult UpdateKhoct(KhoChiTietDto khoctDto)
        {
            if (_khoctService.Update(khoctDto))
            {
                return NoContent();
            }
            return NotFound();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteKho(Guid id)
        {
            if (_khoctService.Delete(id))
            {
                return NoContent();
            }
            return NotFound("Không thể xóa vì kho sản phẩm không tồn tại");
        }
    }
}
