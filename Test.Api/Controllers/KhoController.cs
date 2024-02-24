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
    public class KhoController : ControllerBase
    {
        private readonly IKhoService _khoService;
        public KhoController(IKhoService khoService)
        {
            _khoService = khoService;
        }
        [HttpGet]
        public IActionResult GetKhos()
        {

            return Ok(_khoService.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetKho(Guid id)
        {
            var dmsp = _khoService.Get(id);
            if (dmsp == null)
            {
                return NotFound();//trả về mã 404
            }
            return Ok(dmsp);//trả về mã 200 cho product
        }

        [HttpPost]
        public IActionResult AddKho(KhoDto khoDto)
        {
            khoDto.IdKho = Guid.NewGuid();
            if (_khoService.Add(khoDto) == false)
            {

                return CreatedAtAction(nameof(GetKho), new { id = khoDto.IdKho }, khoDto);

            }


            return Conflict("Kho này đã tồn tại");
        }


        [HttpPut("{id}")]
        public IActionResult UpdateKho(KhoDto khoDto)
        {
            if (_khoService.Update(khoDto))
            {
                return NoContent();
            }
            return NotFound();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteKho(Guid id)
        {
            if (_khoService.Delete(id))
            {
                return NoContent();
            }
            return NotFound("Không thể xóa vì kho không tồn tại");
        }
    }
}
