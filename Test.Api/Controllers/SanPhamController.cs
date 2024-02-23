using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Test.Application.Dto;
using Test.Application.Dto.User;
using Test.Application.Services;

namespace Test.Api.Controllers
{
    [Authorize(Roles = "Admin")]
    [Route("api/[controller]")]
    [ApiController]
    public class SanPhamController : ControllerBase
    {
        private readonly ISanPhamService _spService;
        public SanPhamController(ISanPhamService spService)
        {
            _spService = spService;
        }
        [HttpGet]
        public IActionResult GetSPs()
        {

            return Ok(_spService.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetSP(Guid id)
        {
            var nccs = _spService.Get(id);
            if (nccs == null)
            {
                return NotFound();//trả về mã 404
            }
            return Ok(nccs);//trả về mã 200 cho product
        }

        [HttpPost]
        public IActionResult AddSP(SanPhamDto spDto)
        {
            spDto.IdSanPham = Guid.NewGuid();
            if (_spService.Add(spDto) == false)
            {

                return CreatedAtAction(nameof(GetSP), new { id = spDto.IdSanPham }, spDto);

            }


            return Conflict("Sản phẩm này đã tồn tại");
        }


        [HttpPut("{id}")]
        public IActionResult UpdateSP(SanPhamDto spDto)
        {
            if (_spService.Update(spDto))
            {
                return NoContent();
            }
            return NotFound();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteSP(Guid id)
        {
            if (_spService.Delete(id))
            {
                return NoContent();
            }
            return NotFound("Không thể xóa vì sản phẩm không tồn tại");
        }
    }
}
