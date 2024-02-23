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
    public class DMNSanPhamController : ControllerBase
    {
        private readonly IDMNSanPhamService _dmnService;
        public DMNSanPhamController(IDMNSanPhamService dmnService)
        {
            _dmnService = dmnService;
        }
        [HttpGet]
        public IActionResult GetDMNs()
        {

            return Ok(_dmnService.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetDMN(Guid id)
        {
            var dmn = _dmnService.Get(id);
            if (dmn == null)
            {
                return NotFound();//trả về mã 404
            }
            return Ok(dmn);//trả về mã 200 cho product
        }

        [HttpPost]
        public IActionResult AddDMN(DMNSanPhamDto dmnDto)
        {
            dmnDto.IdDMNSanPham = Guid.NewGuid();
            if (_dmnService.Add(dmnDto) == false)
            {

                return CreatedAtAction(nameof(GetDMN), new { id = dmnDto.IdDMNSanPham }, dmnDto);

            }


            return Conflict("DMN Sản phẩm này đã tồn tại");
        }


        [HttpPut("{id}")]
        public IActionResult UpdateDMN(DMNSanPhamDto dmnDto)
        {
            if (_dmnService.Update(dmnDto))
            {
                return NoContent();
            }
            return NotFound();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteDMN(Guid id)
        {
            if (_dmnService.Delete(id))
            {
                return NoContent();
            }
            return NotFound("Không thể xóa vì dmn sản phẩm không tồn tại");
        }
    }
}
