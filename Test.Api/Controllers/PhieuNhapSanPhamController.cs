using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Test.Application.Dto;
using Test.Application.Services;

namespace Test.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhieuNhapSanPhamController : ControllerBase
    {
        private readonly IPhieuNhapSanPhamService _pnService;
        public PhieuNhapSanPhamController(IPhieuNhapSanPhamService pnService)
        {
            _pnService = pnService;
        }
        [HttpGet]
        public IActionResult GetPNSPs()
        {

            return Ok(_pnService.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetPNSP(Guid id)
        {
            var pn = _pnService.Get(id);
            if (pn == null)
            {
                return NotFound();
            }
            return Ok(pn);
        }

        [HttpPost]
        public IActionResult AddPNSP(PhieuNhapSanPhamDto pnDto)
        {
            pnDto.IdPhieuNhapSanPham = Guid.NewGuid();
            if (_pnService.Add(pnDto) == false)
            {

                return CreatedAtAction(nameof(GetPNSP), new { id = pnDto.IdPhieuNhapSanPham }, pnDto);

            }


            return Conflict("Phieu nhập sản phẩm này đã tồn tại");
        }


        [HttpPut("{id}")]
        public IActionResult UpdatePNSP(PhieuNhapSanPhamDto pnDto)
        {
            if (_pnService.Update(pnDto))
            {
                return NoContent();
            }
            return NotFound();
        }
        [HttpDelete("{id}")]
        public IActionResult DeletePNSP(Guid id)
        {
            if (_pnService.Delete(id))
            {
                return NoContent();
            }
            return NotFound("Không thể xóa vì phiếu nhập này không tồn tại");
        }
    }

}
