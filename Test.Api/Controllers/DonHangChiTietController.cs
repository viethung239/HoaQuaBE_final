using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Test.Application.Dto;
using Test.Application.Services;

namespace Test.Api.Controllers
{
    [Authorize(Roles = "Admin")]
    [Route("api/[controller]")]
    [ApiController]
    public class DonHangChiTietController : ControllerBase
    {
        private readonly IDonHangChiTietService _donhangService;
        public DonHangChiTietController(IDonHangChiTietService donhangService)
        {
            _donhangService = donhangService;
        }
        [HttpGet]
        public IActionResult GetDonHangs()
        {

            return Ok(_donhangService.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetDH(Guid id)
        {
            var dmsp = _donhangService.Get(id);
            if (dmsp == null)
            {
                return NotFound();//trả về mã 404
            }
            return Ok(dmsp);//trả về mã 200 cho product
        }

        [HttpPost]
        public IActionResult AddDH(DonHangChiTietDto donhangDto)
        {
            donhangDto.IdDonHangSanPham = Guid.NewGuid();
            if (_donhangService.Add(donhangDto) == false)
            {

                return CreatedAtAction(nameof(GetDH), new { id = donhangDto.IdDonHangSanPham }, donhangDto);

            }


            return Conflict("don hang này đã tồn tại");
        }


        [HttpPut("{id}")]
        public IActionResult UpdateDH(DonHangChiTietDto donhangDto)
        {
            if (_donhangService.Update(donhangDto))
            {
                return NoContent();
            }
            return NotFound();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteDH(Guid id)
        {
            if (_donhangService.Delete(id))
            {
                return NoContent();
            }
            return NotFound("Không thể xóa vì don hang không tồn tại");
        }
    }
}
