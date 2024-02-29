using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Test.Application.Dto;
using Test.Application.Dto.User;
using Test.Application.Services;

namespace Test.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhieuNhapController : ControllerBase
    {
        private readonly IPhieuNhapService _pnService;
        public PhieuNhapController(IPhieuNhapService pnService)
        {
            _pnService = pnService;
        }
        [HttpGet]
        public IActionResult GetPNs()
        {

            return Ok(_pnService.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetPN(Guid id)
        {
            var pn = _pnService.Get(id);
            if (pn == null)
            {
                return NotFound();
            }
            return Ok(pn);
        }

        [HttpPost]
        public IActionResult AddPN(PhieuNhapDto pnDto)
        {
            pnDto.IdPhieuNhap = Guid.NewGuid();
            if (_pnService.Add(pnDto) == false)
            {

                return CreatedAtAction(nameof(GetPN), new { id = pnDto.IdPhieuNhap }, pnDto);

            }


            return Conflict("Phieu nhập này đã tồn tại");
        }


        [HttpPut("{id}")]
        public IActionResult UpdatePN(PhieuNhapDto pnDto)
        {
            if (_pnService.Update(pnDto))
            {
                return NoContent();
            }
            return NotFound();
        }
        [HttpDelete("{id}")]
        public IActionResult DeletePN(Guid id)
        {
            if (_pnService.Delete(id))
            {
                return NoContent();
            }
            return NotFound("Không thể xóa vì phiếu nhập này không tồn tại");
        }
    }

}
